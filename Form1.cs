using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        private UcakRezervasyonContext context;

        public Form1()
        {
            InitializeComponent();
            context = new UcakRezervasyonContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ucaklar = context.Ucak.ToList();
        }
    }
}
