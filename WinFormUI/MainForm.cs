using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Salut");
        }

        private void ButtonOkMouseHover(object sender, EventArgs e)
        {
            this.buttonOk.ForeColor = Color.BlueViolet;
        }

    }
}
