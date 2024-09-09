﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cargo
{
    public partial class bill_report : Form
    {
        public bill_report()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox11.Text = (double.Parse(textBox10.Text) + double.Parse(textBox9.Text)).ToString();

        }

        private void bill_report_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            AutoCompleteStringCollection nc = new AutoCompleteStringCollection();
            SqlCommand cmd = new SqlCommand("select * from cust_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                nc.Add(rdr[1].ToString());
            }
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = nc;
            rdr.Close();
            rdr.Dispose();

            textBox7.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill b = new bill();
            b.textBox1.Text = textBox1.Text;
            b.textBox2.Text = textBox2.Text;
            b.textBox3.Text = textBox3.Text;
            b.textBox4.Text = textBox4.Text;
            b.textBox5.Text = textBox5.Text;
            b.textBox6.Text = textBox6.Text;
            b.textBox7.Text = textBox7.Text;
            b.textBox8.Text = textBox8.Text;
            b.textBox9.Text = textBox9.Text;
            b.textBox10.Text = textBox10.Text;
            b.textBox11.Text = textBox11.Text;
            this.Hide();
            b.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from cust_details where c_name='" + textBox2.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                textBox3.Text = rdr["c_address"].ToString();
            }
            rdr.Close();
            rdr.Dispose();

            SqlCommand cmd1 = new SqlCommand("select * from trans_details where c_name='" + textBox2.Text + "'", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                textBox1.Text = rdr1["bill_no"].ToString();
                textBox4.Text = rdr1["type_of_goods"].ToString();
                textBox5.Text = rdr1["goods_code"].ToString();
                textBox6.Text = rdr1["date_of_sending"].ToString();
                textBox8.Text = rdr1["goods_qty"].ToString();
                textBox9.Text = rdr1["advance"].ToString();
                textBox10.Text = rdr1["bal"].ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
