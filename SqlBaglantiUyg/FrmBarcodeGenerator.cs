using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlBaglantiUyg
{
    public partial class FrmBarcodeGenerator : Form
    {
        public FrmBarcodeGenerator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Barrcode, Check12Digits;

            if(!string.IsNullOrEmpty(textBox1.Text)&& textBox1.Text.Length==12)
            {
                Check12Digits = textBox1.Text.PadRight(12,'0');
                Barrcode = EAN13Class.EAN13(Check12Digits);
                label4.Text = Barrcode;

                if(!string.Equals(EAN13Class.Barcode13Digits,"") || (EAN13Class.Barcode13Digits != ""))
                {
                    richTextBox1.Text = EAN13Class.Barcode13Digits.ToString();

                    // change colour of certain text in RighTextBox
                    Int32 intStart = Convert.ToInt32(richTextBox1.Text.Length - 1);
                    ChangeTextColor.ChangeColor(richTextBox1, intStart);
                }
            }
        }
    }
}
