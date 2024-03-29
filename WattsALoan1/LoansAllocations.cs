﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WattsALoan1
{
    public partial class LoansAllocations : Form
    {
        public LoansAllocations()
        {
            InitializeComponent();
        }

        private void LoansAllocations_Load(object sender, EventArgs e)
        {
            string strFilename = "employees.xml";

            if (File.Exists(strFilename))
                dsEmployees.ReadXml(strFilename);

            strFilename = "customers.xml";

            if (File.Exists(strFilename))
                dsCustomers.ReadXml(strFilename);

            strFilename = "loans.xml";

            if (File.Exists(strFilename))
                dsLoansAllocations.ReadXml(strFilename);
        }

        private void LoansAllocations_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsLoansAllocations.WriteXml("loans.xml");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
