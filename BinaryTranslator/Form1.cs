using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTranslator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var VerNum = "v0.0.2a";
            lblVerNum.Text = VerNum;
        }

       
    }


    public class Dictionary
    {
        public string EngString = string.Empty;
        public string binString = string.Empty;

        Dictionary<char, Int32> translateBin = new Dictionary<char, Int32>
        {
            {'a', 01100001 },
            {'b', 01100010 },
            {'c', 01100011 },
            {'d', 01100100 },

        };







    }
}


