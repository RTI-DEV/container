using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace plataforma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //panelGeralMenu.Visible = false;
            //(tabControl1.TabPages["tabPage1"] as Control).Visible = false;
            //(tabControl1.TabPages["tabPage2"] as Control).Visible = false;

            //tabControl1.TabPages.Clear();
            //tabControl1.TabPages.Add(tabPage1);
            //tabControl1.SelectedTab = tabPage1;

            hideSubMenu();
            showMenu();
        }

        private void showMenu()
        {
            panelBrowser.Visible = false;
            panelMenu.Visible = true;
            panelMenu.Dock = DockStyle.Fill;
        }

        private void hideMenu()
        {
            panelMenu.Visible = false;
            panelBrowser.Dock = DockStyle.Fill;
            panelBrowser.Visible = true;
        }

        private void hideSubMenu()
        {
            panelSubMenuIntro.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


    

        private void btnTopico02_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("http://rtiinformatica.dev.br:8083/cpw/w10/01-02/index.html");
            webView.Visible = true;
            hideSubMenu();
            hideMenu();
        }

        private void btnTopico03_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("http://rtiinformatica.dev.br:8083/cpw/w10/01-03/index.html");
            webView.Visible = true;
            hideSubMenu();
            hideMenu();
        }

        private void btnTopico04_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("http://rtiinformatica.dev.br:8083/cpw/w10/01-04/index.html");
            webView.Visible = true;
            hideSubMenu();
            hideMenu();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
//            if(webView.)
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            webView.Visible = false;
            hideSubMenu();
            hideMenu();
        }

        private void btnAulas_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuIntro);
        }

        private void btnTopico01_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("http://rtiinformatica.dev.br:8083/cpw/w10/01-01/index.html");
            //timer1.Enabled = true;
            hideSubMenu();
            hideMenu();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            showMenu();

        }
    }
}
