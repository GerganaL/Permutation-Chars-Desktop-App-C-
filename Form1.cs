using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermZadanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            StringBuilder symbols;
            try
            {
                value = int.Parse(textBoxN.Text);
                StringBuilder stringBuilder = new StringBuilder(textBoxSymbols.Text);


                if (stringBuilder.Length < 0 || stringBuilder.Length > 1)
                {
                    MessageBox.Show("Моля въведете само ЕДНА буква!", "Permutation APP");
                    return;
                }


                for (int i = 1; i < value; i++)
                {
                    stringBuilder.Append((char)(stringBuilder[0] + i));

                }

                Permutation permutation = new Permutation();
                permutation.textBoxResult = textBoxResult;
                textBoxResult.Text = "";
                permutation.permute(stringBuilder.ToString(), 0, stringBuilder.Length);
            }
            catch
            {
                MessageBox.Show("Моля въведете число!", "Permutation APP");
            }

        }
    }
}
