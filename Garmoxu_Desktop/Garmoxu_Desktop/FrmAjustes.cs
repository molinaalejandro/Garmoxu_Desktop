using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public partial class FrmAjustes : Form
    {
        private FrmMain Instance;
        private Panel PnlTitle;
        private Panel PnlLateral;
        private Panel PnlMain;
        

        public FrmAjustes(FrmMain instance, Panel pnlTitle, Panel pnlLateral, Panel pnlMain)
        {
            InitializeComponent();
            LblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            tableLayoutPanel16.Height=41;
            FormBorderStyle = FormBorderStyle.None;
            Instance = instance;
            PnlTitle = pnlTitle;
            PnlLateral = pnlLateral;
            PnlMain = pnlMain;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Instance.Visible = true;
            PnlTitle.Visible = true;
            PnlLateral.Visible = true;
            PnlMain.Visible = true;
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
