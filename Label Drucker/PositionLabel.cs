using Label_Drucker.SAMsphereServer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Label_Drucker
{
    public partial class PositionLabel : Form
    {
        public PositionLabel(ORD_Position vPosition, String vSprachEinstellung)
        {
            InitializeComponent();
            InitLabel(vPosition);
        }

        public PositionLabel(ORD_Position vPosition, String vSprachEinstellung, int vMenge)
        {
            InitializeComponent();
            InitLabel(vPosition);
            setzeMenge(vPosition, vMenge);
        }

        public void InitLabel(ORD_Position vPosition)
        {
            auftragsNummer.Text = vPosition.MasterOrderNumber;
            barcodeLabel.Text = "*"+vPosition.Article+"*";
            positionsNummer.Text = vPosition.MasterPositionNumber + "." + vPosition.MasterDeliveryNumber;
            mengenNummer.Text = vPosition.Quantity + "/" + vPosition.Quantity;
            artikelBeschreibungsLabel.Text = vPosition.Article;
            artikelBeschreibungBoxed.Text = vPosition.ArticleDescription;
            datumsLabel.Text = System.DateTime.Now.ToString("dd.MM.yyyy");
            serienNummer.Text = "Info: " + vPosition.HeaderFields.Where(p => p.N == "CustomerPartNo").FirstOrDefault().V;
        }

        public void setzeMenge(ORD_Position vPosition, int vMenge)
        {
            mengenNummer.Text = vMenge + "/" + vPosition.Quantity;
        }

        private void PositionLabel_Load(object sender, EventArgs e)
        {

        }

        private void artikelBeschreibungsLabel_Click(object sender, EventArgs e)
        {

        }

        private void serienNummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void serienNummerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
