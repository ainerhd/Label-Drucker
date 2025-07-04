using System;
using System.Windows.Forms;
using Label_Drucker;
using Label_Drucker.Services;
using Label_Drucker.SAMsphereServer;

namespace Label_Drucker.Demo
{
    static class DemoLabelUsage
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Platzhalter-Position befüllen mit den tatsächlich erwarteten Properties
            var placeholderPosition = new ORD_Position
            {
                MasterOrderNumber = "ORDER-0001",
                MasterPositionNumber = "01",
                MasterDeliveryNumber = "1",
                Quantity = 5,
                Article = "ARTIKEL-ABC",
                ArticleDescription = "Beschreibung Platzhalter",
                
            };

            // 2. Einzel-Position-Etikett (Standard-Menge)
            using (var posLabel = new PositionLabel(placeholderPosition, "de"))
            {
                posLabel.ShowDialog();
                new PrintService("ArtikelListe.txt")
                    .PrintForm(posLabel);
            }

            // 3. Einzel-Position-Etikett (angepasste Menge, z.B. 3)
            using (var posLabelQty = new PositionLabel(placeholderPosition, "de", 3))
            {
                posLabelQty.ShowDialog();
                new PrintService("ArtikelListe.txt")
                    .PrintForm(posLabelQty);
            }

            // 4. Reines Auftrags-Etikett
            using (var orderLabel = new AuftragLabel(placeholderPosition.MasterOrderNumber))
            {
                orderLabel.ShowDialog();
                new PrintService("ArtikelListe.txt")
                    .PrintForm(orderLabel);
            }
        }
    }
}
