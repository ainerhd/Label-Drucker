using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Label_Drucker.SAMsphereServer;

namespace Label_Drucker.Services
{
    /// <summary>
    /// Serviceklasse zur Kapselung der gesamten Drucklogik.
    /// </summary>
    public class PrintService
    {
        private readonly string _artikelListePfad;

        public PrintService(string artikelListePfad)
        {
            _artikelListePfad = artikelListePfad;
        }

        /// <summary>
        /// Druckt eine Liste von Positionen, jede auf einer eigenen Seite. 
        /// </summary>
        public void PrintPositions(List<ORD_Position> positions)
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    int currentPage = 0;
                    pd.PrintPage += (s, e) =>
                    {
                        if (currentPage < positions.Count)
                        {
                            DrawPositionContent(e.Graphics, positions[currentPage]);
                            currentPage++;
                            e.HasMorePages = currentPage < positions.Count;
                        }
                        else
                        {
                            e.HasMorePages = false;
                        }
                    };

                    using (var dlg = new PrintDialog { Document = pd })
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                            pd.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken der Positionen: {ex.Message}", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Druckt den Inhalt eines gegebenen Hauptformulars (z.B. Einzelposition oder Auftrag).
        /// </summary>
        public void PrintForm(Form subform)
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.PrintPage += (s, e) =>
                    {
                        // Zeichne alle Controls des Subforms
                        foreach (Control ctl in subform.Controls)
                        {
                            if (ctl is TextBox tb)
                            {
                                var txt = tb.Text;
                                var fmt = new StringFormat
                                {
                                    Alignment = tb.TextAlign == HorizontalAlignment.Right ? StringAlignment.Far :
                                                tb.TextAlign == HorizontalAlignment.Center ? StringAlignment.Center : StringAlignment.Near,
                                    LineAlignment = StringAlignment.Near,
                                    Trimming = StringTrimming.None
                                };
                                var rect = new RectangleF(tb.Location.X, tb.Location.Y, tb.Width, tb.Height);
                                e.Graphics.DrawString(txt, tb.Font, Brushes.Black, rect, fmt);
                                if (tb.Name.Contains("Boxed"))
                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle(tb.Location, tb.Size));
                            }
                            else
                            {
                                e.Graphics.DrawString(ctl.Text, ctl.Font, Brushes.Black,
                                    ctl.Location.X, ctl.Location.Y);
                            }
                        }
                    };

                    using (var dlg = new PrintDialog { Document = pd })
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                            pd.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Drucken des Formularinhalts: {ex.Message}", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Erweitert die Liste um Mehrfachdruck basierend auf der Artikelmengen-Liste.
        /// </summary>
        public List<ORD_Position> ExpandPositionsByQuantity(List<ORD_Position> positions)
        {
            var artikelListe = LoadArtikelList(_artikelListePfad);
            var expanded = new List<ORD_Position>(positions);

            foreach (var pos in positions)
            {
                if (artikelListe.Contains(pos.Article))
                {
                    if (int.TryParse(pos.Quantity.ToString(), out int menge))
                    {
                        for (int i = 1; i < menge; i++)
                            expanded.Add(pos);
                    }
                }
            }
            return expanded;
        }

        private List<string> LoadArtikelList(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        private void DrawPositionContent(Graphics g, ORD_Position position)
        {
            try
            {
                var form = new PositionLabel(position, "de");
                foreach (Control ctl in form.Controls)
                {
                    if (ctl is TextBox tb)
                    {
                        var txt = tb.Text;
                        var fmt = new StringFormat
                        {
                            Alignment = tb.TextAlign == HorizontalAlignment.Right ? StringAlignment.Far :
                                        tb.TextAlign == HorizontalAlignment.Center ? StringAlignment.Center : StringAlignment.Near,
                            LineAlignment = StringAlignment.Near,
                            Trimming = StringTrimming.None
                        };
                        var rect = new RectangleF(tb.Location.X, tb.Location.Y, tb.Width, tb.Height);
                        g.DrawString(txt, tb.Font, Brushes.Black, rect, fmt);
                        if (tb.Name.Contains("Boxed"))
                            g.DrawRectangle(Pens.Black,
                                new Rectangle(tb.Location, tb.Size));
                    }
                    else
                    {
                        g.DrawString(ctl.Text, ctl.Font, Brushes.Black,
                            ctl.Location.X, ctl.Location.Y);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Zeichnen der Position {position.PositionNumber}: {ex.Message}", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
