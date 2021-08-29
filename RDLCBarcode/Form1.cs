using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLCBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBenerate_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            Image img = barcode.Encode(BarcodeLib.TYPE.UPCA, txtBarcode.Text, Color.Black, Color.White, 100, 30);
            pictureBox.Image = img;
            this.appData1.Clear();
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                for (int i = 0; i < number.Value; i++)
                    this.appData1.Barcode.AddBarcodeRow(txtBarcode.Text, ms.ToArray());
            }
            using (frmReport frm = new frmReport(this.appData1.Barcode))
            {
                frm.ShowDialog();
            }
        }
    }
}
