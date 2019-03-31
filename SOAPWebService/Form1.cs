using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOAPWebService.net.webservicex.www;

namespace SOAPWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public CurrencyConvertor currencyconverter = new CurrencyConvertor();

        private void button1_Click(object sender, EventArgs e)
        {
            Currency currencyFrom = (Currency)comboBox1.SelectedItem;
            Currency currencyTo   = (Currency)comboBox2.SelectedItem;

            double value = currencyconverter.ConversionRate(currencyFrom,currencyTo);

            labelResult.Text =  "The difference with the two different coins is:";
            labelResult2.Text = value + "   ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Currency));
            comboBox1.SelectedItem = Currency.USD;

            comboBox2.DataSource = Enum.GetValues(typeof(Currency));
            comboBox2.SelectedItem = Currency.EUR;
        }
    }
}
