using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationForm
{
    public partial class readForm : Form
    {
        public readForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string containerInterface
        {
            get
            {
                return container.Text;
            }
            set
            {
                container.Text = value;
            }
        }
    }
}
