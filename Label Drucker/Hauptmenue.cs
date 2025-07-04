using Label_Drucker.SAMsphereServer;
using Label_Drucker.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Label_Drucker
{
    public partial class Hauptmenue : Form
    {
        // Statische Daten
        static int positionZähler;  // Aktuelle Position in der Liste der Positionen
        static float scaleFactor = 1.0f;  // Skalierungsfaktor für das Drucken

        static String auftragsNummer;  // Auftragsnummer
        static String sprachEinstellung = "de";  // Spracheinstellung (Standard: Deutsch)
        string artikelListePfad = @"Z:\1 Auma-Organisation\1.1 SCK\1.1.6 IV\IFS Auftragsetiketten\Filterlisten\Artikelliste.txt";  // Definiere den Pfad zur Artikelliste
        string beschreibungListePfad = @"Z:\1 Auma-Organisation\1.1 SCK\1.1.6 IV\IFS Auftragsetiketten\Filterlisten\Beschreibungsliste.txt";  // Definiere den Pfad zur Beschreibungliste


        static ORD_Order statAuftrag;  // Der aktuelle Auftrag
        static ORD_Position statPosition;  // Die aktuelle Position
        static List<ORD_Position> positionListe;  // Liste der Positionen des Auftrags

        static bool gültigerAuftrag;  // Prüft, ob der Auftrag gültig ist
        static bool gültigePositionen;  // Prüft, ob die Positionen gültig sind
        static bool gültigeÄnderung;  // Prüft, ob eine Änderung 
        static bool printNumber; // Prüft was gedruckt werden soll

        private readonly PrintService _printService;


        // Liste aller Buttons, die deaktiviert werden sollen
        private List<Button> buttonsToDisable = new List<Button>();

        public Hauptmenue()
        {
            InitializeComponent();
            _printService = new PrintService(artikelListePfad);

            // Füge die Buttons hinzu, die deaktiviert werden sollen (außer dem Suche-Button)
            buttonsToDisable.Add(tasteHoch);
            buttonsToDisable.Add(tasteRunter);
            buttonsToDisable.Add(druckButton);
            buttonsToDisable.Add(MengePrintButton);
            buttonsToDisable.Add(showAktuellePosition);
            buttonsToDisable.Add(showAuftrag);
            buttonsToDisable.Add(printAktuellePosition);


            // Alle Buttons deaktivieren
            ToggleButtons(false);

            // Füge ein KeyDown-Event für die Auftragsnummer-Box hinzu
            auftragsNummerBox.KeyDown += new KeyEventHandler(auftragsNummerBox_KeyDown);
        }


        // Diese Funktion wird aufgerufen, wenn eine Taste in der Auftragsnummer-Box gedrückt wird
        private void auftragsNummerBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Überprüfe, ob die Enter-Taste gedrückt wurde
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Verhindert den "Kling"-Sound bei Drücken der Enter-Taste
                InitProgramm();  // Starte die Suchfunktion
            }
        }


        // Aktiviert oder deaktiviert die Buttons je nach dem übergebenen bool-Wert
        private void ToggleButtons(bool enable)
        {
            foreach (var button in buttonsToDisable)
            {
                button.Enabled = enable;
            }
        }


        // Diese Funktion wird aufgerufen, wenn auf den "Suche"-Button geklickt wird
        private void tempTest_Click(object sender, EventArgs e)
        {
            InitProgramm();
        }

        
        // Diese Funktion initialisiert das Programm basierend auf der eingegebenen Auftragsnummer
        private void InitProgramm()
        {
            try
            {
                // Übertrage die Eingabe in das statische Objekt
                auftragsNummer = auftragsNummerBox.Text;

                // Erstelle den Samclient und importiere den Auftrag, wenn gültig
                var samclient = new SAMsphereServer.SAMsphereClient();
                var order = samclient.ORD_ERP_Order("de-DE", "iprod", auftragsNummer, true, false);
                statAuftrag = order;

                //Sortiere die Einträge
                statAuftrag.Positions = SortingPosition(order);

                // Unterbreche die Funktion, wenn die aktuelle Eingabe ungültig ist
                if (!CheckAuftrag(order))
                {
                    resetDaten();
                    ToggleButtons(false); // Buttons deaktivieren
                    return;
                }

                // Überprüfe, ob der Auftrag gültige Positionen hat
                if (CheckPositon(order))
                {
                    // Lade die Positionen des Auftrags
                    LoadPositionGridView(order);
                    LoadPositionEttiketPanel(order.Positions[0]);
                    ToggleButtons(true); // Buttons aktivieren
                }
                else
                {
                    ToggleButtons(false); // Buttons deaktivieren, wenn keine gültigen Positionen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Initialisierung des Programms: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleButtons(false); // Buttons deaktivieren
            }
        }


        // Sortiere den Array
        public ORD_Position[] SortingPosition(ORD_Order vAuftrag)
        {
            // Filtern Sie die Positionen ohne PositionNumber heraus
            var validPositions = vAuftrag.Positions
                                          .Where(pos => pos.PositionNumber != null)
                                          .OrderBy(pos => Convert.ToInt32(pos.PositionNumber))
                                          .ToArray();

            return validPositions;
        }

        // Setzt alle Daten zurück und deaktiviert die Buttons
        public void resetDaten()
        {
            try
            {
                if (!auftragsNummerBox.Equals(auftragsNummer))
                {
                    positionZähler = 0;
                    dataGridView1.DataSource = null;
                    ettiketPanel.Controls.Clear();
                    ToggleButtons(false); // Buttons deaktivieren
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Zurücksetzen der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Prüft, ob der Auftrag gültig ist (nicht null)
        private Boolean CheckAuftrag(ORD_Order vAuftrag)
        {
            try
            {
                if (vAuftrag == null)
                {
                    gültigerAuftrag = false;
                    gültigeÄnderung = false;
                }
                else
                {
                    gültigerAuftrag = true;
                    gültigeÄnderung = true;
                }
                return gültigerAuftrag;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Auftragsprüfung: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Prüft, ob die Positionen des Auftrags gültig sind (nicht null oder leer)
        private Boolean CheckPositon(ORD_Order vAuftrag)
        {
            try
            {
                if (vAuftrag.Positions == null || vAuftrag.Positions.Length == 0)
                {
                    gültigePositionen = false;
                    gültigeÄnderung = false;
                }
                else
                {
                    gültigePositionen = true;
                    gültigeÄnderung = true;
                    positionListe = vAuftrag.Positions.ToList();
                }
                return gültigePositionen;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Überprüfung der Positionen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Lädt die Positionen des Auftrags in das GridView
        private void LoadPositionGridView(ORD_Order vAuftrag)
        {
            try
            {
                dataGridView1.DataSource = vAuftrag.Positions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Positionen in die GridView: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Lädt die ausgewählte Position in das Etikett-Panel
        private void LoadPositionEttiketPanel(ORD_Position vPosition)
        {
            try
            {
                ettiketPanel.Controls.Clear();

                PositionLabel etikett = new PositionLabel(vPosition, sprachEinstellung)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                ettiketPanel.Controls.Add(etikett);
                etikett.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden des Etiketts in das Panel: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Lädt den Auftrag
        private void LoadPositionAuftragPanel()
        {
            try
            {
                ettiketPanel.Controls.Clear();

                AuftragLabel auftrag = new AuftragLabel(statAuftrag.OrderNumber)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                ettiketPanel.Controls.Add(auftrag);
                auftrag.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden des Etiketts in das Panel: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 
        private void LoadPositionEttiketPanelMitMenge(ORD_Position vPosition)
        {
            try
            {
                ettiketPanel.Controls.Clear();

                PositionLabel etikett = new PositionLabel(vPosition, sprachEinstellung, Convert.ToInt32(mengeBox.Text))
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                ettiketPanel.Controls.Add(etikett);
                etikett.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden des Etiketts in das Panel: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Bewegt sich nach oben in der Positionsliste und zeigt die entsprechende Position an
        private void tasteHoch_Click(object sender, EventArgs e)
        {
            try
            {
                if (positionZähler < statAuftrag.Positions.Length - 1)
                {
                    positionZähler++;
                }
                else
                {
                    positionZähler = 0;
                }
                LoadPositionEttiketPanel(statAuftrag.Positions[positionZähler]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Navigation: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Bewegt sich nach unten in der Positionsliste und zeigt die entsprechende Position an
        private void tasteRunter_Click(object sender, EventArgs e)
        {
            try
            {
                if (positionZähler > 0)
                {
                    positionZähler--;
                }
                else
                {
                    positionZähler = statAuftrag.Positions.Length - 1;
                }
                LoadPositionEttiketPanel(statAuftrag.Positions[positionZähler]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Navigation: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Druckt die ausgewählten Positionen
        private void PrintPositions(List<ORD_Position> positions)
        {
            try
            {
                // Erstelle das PrintDocument
                using (PrintDocument pd = new PrintDocument())
                {
                    int currentPageIndex = 0;

                    pd.PrintPage += (sender, e) =>
                    {
                        // Zeichne jede Position auf eine eigene Druckseite
                        if (currentPageIndex < positions.Count)
                        {
                            // Rufe die Position ab, die gedruckt werden soll
                            var position = positions[currentPageIndex];

                            // Drucke den Inhalt der Position (als Text, Barcode oder was benötigt wird)
                            DrawPositionContent(e.Graphics, position);

                            currentPageIndex++;
                            e.HasMorePages = (currentPageIndex < positions.Count);
                        }
                        else
                        {
                            e.HasMorePages = false;
                        }
                    };

                    // Zeige den Druckdialog an
                    using (PrintDialog printDialog = new PrintDialog())
                    {
                        printDialog.Document = pd;
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            pd.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken der Positionen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Erstellt die Vektorgrafik für das Printdocument
        private void DrawPositionContent(Graphics graphics, ORD_Position position)
        {
            try
            {
                var subform = new PositionLabel(position, sprachEinstellung); // Erstelle die Subform

                // Gehe durch jedes Steuerelement im Subform
                foreach (Control control in subform.Controls)
                {
                    // Wenn das Steuerelement eine TextBox ist
                    if (control is TextBox textBox)
                    {
                        // Bereite das Zeichnen des Texts vor
                        string text = textBox.Text;
                        Font font = textBox.Font;
                        Brush brush = Brushes.Black;

                        // Erstelle ein StringFormat für den Zeilenumbruch
                        StringFormat stringFormat = new StringFormat
                        {
                            Alignment = StringAlignment.Near,   // Standard linksbündig
                            LineAlignment = StringAlignment.Near,
                            Trimming = StringTrimming.None      // Kein Abschneiden des Textes
                        };

                        // Berechne die Position basierend auf der Ausrichtung
                        if (textBox.TextAlign == HorizontalAlignment.Right)
                        {
                            stringFormat.Alignment = StringAlignment.Far; // Rechtsbündig
                        }
                        else if (textBox.TextAlign == HorizontalAlignment.Center)
                        {
                            stringFormat.Alignment = StringAlignment.Center; // Zentriert
                        }

                        // Definiere den Bereich, in dem der Text gezeichnet wird
                        RectangleF textRect = new RectangleF(
                            textBox.Location.X,       // X-Position
                            textBox.Location.Y,       // Y-Position
                            textBox.Width,            // Breite des TextBox
                            textBox.Height            // Höhe des TextBox
                        );

                        // Zeichne den Text mit automatischem Zeilenumbruch
                        graphics.DrawString(
                            text,           // Text des Steuerelements
                            font,           // Schriftart des Steuerelements
                            brush,          // Farbe des Textes
                            textRect,       // Rechteck für Text mit Umbruch
                            stringFormat    // Format für Textausrichtung und Umbruch
                        );

                        // Zeichne den Rahmen um die TextBox, wenn der Name "Boxed" enthält
                        if (textBox.Name.Contains("Boxed"))
                        {
                            graphics.DrawRectangle(
                                Pens.Black,                  // Farbe des Rahmens
                                new Rectangle(
                                    textBox.Location.X,      // X-Position des Rahmens
                                    textBox.Location.Y,      // Y-Position des Rahmens
                                    textBox.Width,           // Breite des Rahmens
                                    textBox.Height           // Höhe des Rahmens
                                )
                            );
                        }
                    }
                    else
                    {
                        // Zeichne den Text anderer Steuerelemente direkt
                        graphics.DrawString(
                            control.Text,            // Text des Steuerelements
                            control.Font,            // Schriftart des Steuerelements
                            Brushes.Black,           // Farbe des Textes
                            control.Location.X,      // X-Position des Steuerelements
                            control.Location.Y       // Y-Position des Steuerelements
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Zeichnen des Inhalts der Position {position.PositionNumber}: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Druckbutton, der die ausgewählten Positionen oder die aktuell ausgewählte Position druckt
        private void druckButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = PrintSelectedPositions();
                var expanded = _printService.ExpandPositionsByQuantity(selected);
                _printService.PrintPositions(expanded);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Druckt die ausgewählten Positionen aus der Suchbox basierend auf der Eingabe und gibt eine Liste der Positionen zurück
        public List<ORD_Position> PrintSelectedPositions()
        {
            List<ORD_Position> selectedPositions = new List<ORD_Position>();

            try
            {
                string input = positionsNummernBox.Text.Trim();

                // Prüfe, ob die Eingabe leer ist
                if (string.IsNullOrEmpty(input))
                {
                    // Wenn keine Eingabe vorhanden ist, füge die aktuell ausgewählte Position hinzu
                    if (statAuftrag != null && statAuftrag.Positions.Length > 0)
                    {
                        selectedPositions.AddRange(positionListe);
                    }
                    else
                    {
                        MessageBox.Show("Keine Position ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Wenn der Benutzer "0" eingegeben hat, wähle alle Positionen
                    if (input == "0")
                    {
                    }
                    else
                    {
                        string[] parts = input.Split(',');

                        foreach (string part in parts)
                        {
                            if (part.Contains("-"))
                            {
                                // Bereichsangabe, z.B. "1-3"
                                string[] rangeParts = part.Split('-');
                                if (rangeParts.Length == 2 && int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                                {
                                    for (int i = start; i <= end; i++)
                                    {
                                        var positionsToAdd = positionListe.Where(p => p.PositionNumber == i.ToString()).ToList();
                                        selectedPositions.AddRange(positionsToAdd);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ungültiger Bereich: " + part, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else if (part.Contains("."))
                            {
                                // Spezifische Position mit Lieferposition, z.B. "1.1"
                                string[] positionParts = part.Split('.');
                                if (positionParts.Length == 2 && int.TryParse(positionParts[0], out int posNumber) && int.TryParse(positionParts[1], out int subPosNumber))
                                {
                                    var positionToAdd = positionListe.FirstOrDefault(p => p.PositionNumber == posNumber.ToString() && p.DeliveryNumber == subPosNumber.ToString());
                                    if (positionToAdd != null)
                                    {
                                        selectedPositions.Add(positionToAdd);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Position " + part + " nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else if (int.TryParse(part, out int singlePositionNumber))
                            {
                                // Einzelposition hinzufügen, z.B. "1"
                                var positionsToAdd = positionListe.Where(p => p.PositionNumber == singlePositionNumber.ToString()).ToList();
                                if (positionsToAdd.Count > 0)
                                {
                                    selectedPositions.AddRange(positionsToAdd);
                                }
                                else
                                {
                                    MessageBox.Show("Position " + part + " nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ungültige Eingabe: " + part, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Auswahl der Positionen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return selectedPositions;
        }


        // Funktion zum Laden der Artikelliste aus einer Textdatei
        private List<string> LadeArtikelListe(string dateiPfad)
        {
            try
            {
                // Lies alle Zeilen der Textdatei und speichere sie in einer Liste
                return System.IO.File.ReadAllLines(dateiPfad).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Artikelliste: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>(); // Leere Liste zurückgeben bei Fehler
            }
        }


        // Funktion, die überprüft, ob eine Position einen Artikel aus der Liste enthält
        private bool PositionEnthältArtikel(ORD_Position position, List<string> artikelListe)
        {
            // Überprüfe, ob der Artikel der Position in der Artikelliste vorhanden ist
            return artikelListe.Contains(position.Article); // Ersetze ArtikelNummer durch das eigentliche Attribut in ORD_Position
        }


        // Funktion, um Positionen nach Artikelmenge hinzuzufügen und zurückzugeben
        private List<ORD_Position> DruckePositionNachMenge(List<ORD_Position> positionListe, string artikelListePfad)
        {
            // Lade die Artikelliste aus der Textdatei
            List<string> artikelListe = LadeArtikelListe(artikelListePfad);
            List<ORD_Position> erweiterteListe = new List<ORD_Position>(positionListe);

            foreach (var position in positionListe)
            {
                // Überprüfe, ob die Position einen Artikel aus der Liste enthält
                if (PositionEnthältArtikel(position, artikelListe))
                {
                    // Wenn die Position den Artikel enthält, füge sie entsprechend der Menge mehrfach hinzu
                    int menge = Convert.ToInt32(position.Quantity);  // Ersetze Menge durch das tatsächliche Attribut in ORD_Position

                    for (int i = 1; i < menge; i++)  // i=1, da die Position bereits einmal in der Liste ist
                    {
                        erweiterteListe.Add(position); // Füge die Position erneut hinzu
                    }
                }
            }

            return erweiterteListe;
        }


        // Mengen Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPositionEttiketPanelMitMenge(statAuftrag.Positions[positionZähler]);

                PositionLabel pos = new PositionLabel(statAuftrag.Positions[positionZähler], sprachEinstellung, Convert.ToInt32(mengeBox.Text));
                _printService.PrintForm(pos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Funktion, die die aktuelle Position in einen Vector umwandelt und druckt
        private void PrintSubformContentDirectly(Form subform)
        {
            try
            {
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.PrintPage += (sender, e) =>
                    {
                        {

                            // Gehe durch jedes Steuerelement im Subform
                            foreach (Control control in subform.Controls)
                            {
                                // Wenn das Steuerelement eine TextBox ist
                                if (control is TextBox textBox)
                                {
                                    // Bereite das Zeichnen des Texts vor
                                    string text = textBox.Text;
                                    Font font = textBox.Font;
                                    Brush brush = Brushes.Black;

                                    // Erstelle ein StringFormat für den Zeilenumbruch
                                    StringFormat stringFormat = new StringFormat
                                    {
                                        Alignment = StringAlignment.Near,   // Standard linksbündig
                                        LineAlignment = StringAlignment.Near,
                                        Trimming = StringTrimming.None      // Kein Abschneiden des Textes
                                    };

                                    // Berechne die Position basierend auf der Ausrichtung
                                    if (textBox.TextAlign == HorizontalAlignment.Right)
                                    {
                                        stringFormat.Alignment = StringAlignment.Far; // Rechtsbündig
                                    }
                                    else if (textBox.TextAlign == HorizontalAlignment.Center)
                                    {
                                        stringFormat.Alignment = StringAlignment.Center; // Zentriert
                                    }

                                    // Definiere den Bereich, in dem der Text gezeichnet wird
                                    RectangleF textRect = new RectangleF(
                                        textBox.Location.X,       // X-Position
                                        textBox.Location.Y,       // Y-Position
                                        textBox.Width,            // Breite des TextBox
                                        textBox.Height            // Höhe des TextBox
                                    );

                                    // Zeichne den Text mit automatischem Zeilenumbruch
                                    e.Graphics.DrawString(
                                        text,           // Text des Steuerelements
                                        font,           // Schriftart des Steuerelements
                                        brush,          // Farbe des Textes
                                        textRect,       // Rechteck für Text mit Umbruch
                                        stringFormat    // Format für Textausrichtung und Umbruch
                                    );

                                    // Zeichne den Rahmen um die TextBox, wenn der Name "Boxed" enthält
                                    if (textBox.Name.Contains("Boxed"))
                                    {
                                        e.Graphics.DrawRectangle(
                                            Pens.Black,                  // Farbe des Rahmens
                                            new Rectangle(
                                                textBox.Location.X,      // X-Position des Rahmens
                                                textBox.Location.Y,      // Y-Position des Rahmens
                                                textBox.Width,           // Breite des Rahmens
                                                textBox.Height           // Höhe des Rahmens
                                            )
                                        );
                                    }
                                }
                                else
                                {
                                    // Zeichne den Text anderer Steuerelemente direkt
                                    e.Graphics.DrawString(
                            control.Text,            // Text des Steuerelements
                            control.Font,            // Schriftart des Steuerelements
                            Brushes.Black,           // Farbe des Textes
                            control.Location.X,      // X-Position des Steuerelements
                            control.Location.Y       // Y-Position des Steuerelements
                        );
                                }
                            }
                        }
                    };

                    using (PrintDialog printDialog = new PrintDialog())
                    {
                        printDialog.Document = pd;

                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            pd.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken des Subform-Inhalts: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AuftragLaden_Click(object sender, EventArgs e)
        {
            LoadPositionAuftragPanel();
        }

        private void showAktuellePosition_Click(object sender, EventArgs e)
        {
            LoadPositionEttiketPanel(statAuftrag.Positions[positionZähler]);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (printNumber)
            {
                AuftragLabel auftrag = new AuftragLabel(statAuftrag.OrderNumber);
                _printService.PrintForm(auftrag);
            }
            else
            {
                PositionLabel position = new PositionLabel(statAuftrag.Positions[positionZähler], sprachEinstellung);
                _printService.PrintForm(position);
            }
        }
    }
}

