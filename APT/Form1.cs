using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace APT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ind, i;

        bool timerMode = false;
        List<Item> item = new List<Item>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void butAddItemGB_Click(object sender, EventArgs e)
        {
            if(radCom.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "com"));
            }
            else if (radFr.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "fr"));
            }
            else if(radCa.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "ca"));
            }
            else if(radEs.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "es"));
            }
            else if(radIt.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "it"));
            }
            else if(radDe.Checked == true && Regex.IsMatch(tbxPL.Text, @"^\d+$") && tbxPL.Text != "" && tbxPID.Text != "")
            {
                item.Add(new Item(tbxPID.Text, int.Parse(tbxPL.Text), "de"));
            }
            else
            {
                MessageBox.Show("Please, enter correct value and retry.");
            }
            listBox1.Items.Clear();
            addItemToListBox();
            refresh.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && item.Count > 0)
            {
                clock.Start();
            }
        }

        private void butDeleteItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            addItemToListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind = int.Parse(listBox1.SelectedIndex.ToString());
            valueToLabel(ind);
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            addItemToListBox();
            refresh.Stop();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            i = 0;
            labTime.Text = Date.ToString();
            if (timerMode = true && Date.Minute % 10 == 3)
            {
                
            }
            else
            {
                item.ForEach(delegate
                {
                    item[i].searchAuto();
                });
            }
        }

        private void addItemToListBox()
        {
            i = 0;
            item.ForEach(delegate{
                listBox1.Items.Add("[" + item[i].getProductID() + "] " + item[i].getName());
                i++;
            });
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void tbxPID_MouseClick(object sender, MouseEventArgs e)
        {
            tbxPID.SelectAll();
        }

        private void tbxPL_MouseClick(object sender, MouseEventArgs e)
        {
            tbxPL.SelectAll();
        }

        private void valueToLabel(int i)
        {
            labActualPrice.Text = item[ind].getPrice().ToString() + "$";
            labMaximalPrice.Text = item[ind].getMaxPrice().ToString() + "$";
            labMinimalPrice.Text = item[ind].getMinPrice().ToString() + "$";
        }

        private void tbxPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
