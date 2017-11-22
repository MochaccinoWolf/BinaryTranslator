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
        /// <summary>
        /// Simple Binary Translation Program
        /// Written in C#
        /// Code By Benjamin Gray
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var VerNum = "v0.0.3a";
            lblVerNum.Text = VerNum;
        }

       
    }


    public class BinDictionary
    {
        /// <summary>
        /// http://sticksandstones.kstrom.com/appen.html
        /// </summary>
        public string EngString = string.Empty;
        public string binString = string.Empty;

        Dictionary<char, string> translateBin = new Dictionary<char, string>
        {
            {'a', "01100001" },
            {'b', "01100010" },
            {'c', "01100011" },
            {'d', "01100100" },
            {'e', "01100101" },
            {'f', "01100110" },
            {'g', "01100111" },
            {'h', "01101000" },
            {'i', "01101001" },
            {'j', "01101010" },
            {'k', "01101011" },
            {'l', "01101010" },
            {'m', "01101101" },
            {'n', "01101110" },
            {'o', "01101111" },
            {'p', "01110000" },
            {'q', "01110000" },
            {'r', "01110010" },
            {'s', "01110011" },
            {'t', "01110100" },
            {'u', "01110101" },
            {'v', "01110110" },
            {'w', "01110111" },
            {'x', "01111000" },
            {'y', "01111001" },
            {'z', "01111010" },
            
        };







    }
}


