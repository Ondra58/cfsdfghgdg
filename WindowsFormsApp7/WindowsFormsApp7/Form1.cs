using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <int> list = new List<int>();
        
        public void Vypis(List<int> list)
        {
            listBox1.Items.Clear();
            foreach (int cislo in list)
            {
                listBox1.Items.Add(cislo);
            }
        }
        public int DruheMax(int druhemax)
        {
            int max = int.MinValue;
            druhemax = int.MinValue;
            foreach (int cislo in list)
            {
                if(cislo > druhemax)
                {
                    if (cislo > max)
                    {
                        max = cislo;
                    }
                    else 
                    {
                        druhemax = cislo;
                    }
                }
            }
            return druhemax;
        }
        Random rng = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            int druhemax = int.MinValue;
            int max= int.MinValue;
            bool dokonale = false;
            for (int i = 0; i < 10; i++)
            {
                int randomak = rng.Next(0, 50);
                list.Add(randomak);
            }
            Vypis(list);
            label1.Text = DruheMax(druhemax).ToString();
            label2.Text = CifernySoucet(max).ToString();
            label3.Text = Dokonale(dokonale).ToString();
        }
        private int CifernySoucet(int max)
        {
            max = int.MinValue;
            foreach (int cislo in list)
            {
                if (cislo > max)
                {
                    max = cislo;
                }
            }
            int soucet = 0;
            while (max > 1)
            {
                int zbytek = max % 10; 
                soucet += zbytek;
                max /= 10;
            }
            return soucet;
        }
        public bool Dokonale(bool dokonale)
        {
            dokonale = false;
            int soucet = 0;
            foreach (int cislo in list)
            {
                for (int i = 1; i < cislo; i++)
                {
                    if (cislo % i == 0)
                    {
                        soucet += i;
                    }
                }
                if (soucet == cislo)
                {
                    dokonale = true;
                }
            }
            return dokonale;        
        }
    }
}
