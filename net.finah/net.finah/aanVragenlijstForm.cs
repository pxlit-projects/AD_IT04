using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;

namespace net.finah
{
    public partial class aanVragenlijstForm : Form
    {
        public aanVragenlijstForm()
        {
            InitializeComponent();
        }

        private void aanVragenlijstForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(API.DB.GetVragen());

        }
    }
}
