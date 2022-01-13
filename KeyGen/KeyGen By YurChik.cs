using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form1 : Form
    {

        const String KEY_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        string GenerateKeyPart()
        {
            String result = "";
            for (int i = 1; i <= 5; i++) result += KEY_CHARS[rnd.Next(0, KEY_CHARS.Length)];
            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= nudKeyCount.Value; i++)
                textBox1.Text += GenerateKeyPart() + "-" + GenerateKeyPart() + "-" + GenerateKeyPart() + "\r\n";
        }

        private void nudKeyCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
