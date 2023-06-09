﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UkrashenieApp41IS.Utils;

namespace UkrashenieApp41IS.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = DbConnect.db.Order.ToList();
            orderProductBindingSource.DataSource = DbConnect.db.OrderProduct.ToList();
        }
    }
}