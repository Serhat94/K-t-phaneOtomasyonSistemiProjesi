﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace WinFormKOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string getTabloName()
        {
            switch (cbbTableName.SelectedIndex)
            {
                case 0:
                    return "yazarlar";

                case 1:
                    return "yayinevleri";

                case 2:
                    return "turler";

                case 3:
                    return "dolaplar";

                case 4:
                    return "kitaplar";

                case 5:
                    return "kullanicilar";

                case 6:
                    return "okuyucular";

                default:
                    return "";

               

            }    
            
        }
        void tableLoad()
        {
            if(!string.IsNullOrEmpty(getTabloName()))
            {
                dg.DataSource = IDataBase.DataToDataTable("Select * From " + getTabloName());
            }
        }

        private void cbbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLoad();
        }
    }
}
