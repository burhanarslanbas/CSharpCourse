﻿using SingletonDesignPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Singleton nesne1 = Singleton.NesneVer();
            Singleton nesne2 = Singleton.NesneVer();
            if(nesne1.Equals(nesne2))
            {
                //Nesneler aynıysa
                MessageBox.Show("Test");
            }
        }
    }
}
