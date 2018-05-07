using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary.Add("Bmw", new string[] { "313", "530", "X-6" });
            dictionary.Add("Mercedes-Benz", new string[] { "E-270", "E-200", "S-350" });
        }
        StringBuilder stringBuilder = new StringBuilder();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string[] val;
            dictionary.TryGetValue(comboBox1.Text, out val);
            comboBox2.Items.AddRange(val);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
 

}
