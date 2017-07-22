using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIS.Class;
using EIS.Controller;
using EIS.Model;
using Z80NavBarControl.Z80NavBar.Themes;
namespace EIS
{
    public partial class Form1 : Form
    {

        DashboardController DCON = new DashboardController();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NavigationBar.Initialize(DCON.generateMenu(), new ThemeSelector(Theme.Dark).CurrentTheme);
            z80_Navigation1.Initialize(DCON.generateMenu("A"), new ThemeSelector(Theme.Dark).CurrentTheme);
        }
    }
}
