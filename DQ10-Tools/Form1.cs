﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQ10_Tools
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e) {


            string[] itemDB;
            itemDB = new string[] {
                "どうこうせき",
                "てっこうせき",
                "ぎんこうせき"

            };



        }
  

        public void button1_Click(object sender, EventArgs e)
        {
            String Copper = ItemDataBase.Material[0].itemName;

            Console.Write(Copper);
        }
    }
}