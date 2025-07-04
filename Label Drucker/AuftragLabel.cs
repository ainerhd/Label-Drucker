using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Drucker
{
    public partial class AuftragLabel : Form
    {
        public AuftragLabel(String vAuftragnummer)
        {
            test(vAuftragnummer);
            InitializeComponent();
        }

        public void test (string vAuftragnummer)
        {
            String temp = "*" + vAuftragnummer + "*";
            barcodeLabel.Text = temp;
        }
    }
}
