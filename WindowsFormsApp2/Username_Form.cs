using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Username_Form : Form
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public Username_Form()
        {
            InitializeComponent();
        }
        public Username_Form(string player1,string player2):this()
        {

            this.Player1 = player1;
            this.Player2 = player2;

        }
    }
}
