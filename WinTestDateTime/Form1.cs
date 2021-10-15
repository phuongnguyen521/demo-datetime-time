using DemoDateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource source = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static IEnumerable<Testdatetime> getData()
        {
            IEnumerable<Testdatetime> result = null;
            try
            {
                using var context = new DEMOTIMEDATEContext();
                result = context.Testdatetimes.ToList();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get datetime from db");
            }
            return result;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = getData();
                dgv_DateTime.DataSource = null;
                dgv_DateTime.DataSource = source;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Date from db");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpDateTime.Value;
                Testdatetime obj = new Testdatetime(date,date);
                MessageBox.Show($"datetime: {obj.Time1} \ndate:{obj.Time2}",
                    "Show inserted date");
                using var context = new DEMOTIMEDATEContext();
                context.Testdatetimes.Add(obj);
                context.SaveChanges();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Date into db");
            }
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse( mtbShipping.Text);
            Testdatetime obj = new Testdatetime(date, date);
            int comparison = DateTime.Compare((DateTime)obj.Time1, (DateTime)obj.Time2);
            string mess = null;
            if (comparison == 0)
            {
                mess = "datetime is equal to date";
            }
            MessageBox.Show($"datetime: {obj.Time1} \ndate:{obj.Time2}\n{mess}",
                   "Show inserted shipping");
            using var context = new DEMOTIMEDATEContext();
            context.Testdatetimes.Add(obj);
            context.SaveChanges();
        }
    }
}
