using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_Pattern
{
    public partial class Form1 : Form
    {
        ConcreteAggregate cAggregate;
        ConcreteIterator cIterator;
        public Form1()
        {
            InitializeComponent();
            Iterate();
            all_rbtn.Checked = true;
        }

        private void Iterate()
        {
            cAggregate = new ConcreteAggregate();
            cAggregate.createData();
            cIterator = (ConcreteIterator)cAggregate.createIterator();
        }

        private void all_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (all_rbtn.Checked == true)
            {
                lbDisplay.Items.Add(cIterator.first("Albums"));
                cIterator.next("Albums");
                while(!cIterator.isDone("Albums"))
                {
                    lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                    cIterator.next("Albums");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }

        private void avengedSevenfold_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (avengedSevenfold_rbtn.Checked == true)
            {
                cIterator.first("Bands");

                while (!cIterator.isDone("Bands"))
                {
                    if (cIterator.currentItem("Bands") == "Avenged Sevenfold")
                    {
                        lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                        cIterator.next("Bands");
                    }
                    else
                        cIterator.next("Bands");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }

        private void breakingBenjamin_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (breakingBenjamin_rbtn.Checked == true)
            {
                cIterator.first("Bands");

                while (!cIterator.isDone("Bands"))
                {
                    if (cIterator.currentItem("Bands") == "Breaking Benjamin")
                    {
                        lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                        cIterator.next("Bands");
                    }
                    else
                        cIterator.next("Bands");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }

        private void linkinPark_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (linkinPark_rbtn.Checked == true)
            {
                cIterator.first("Bands");

                while (!cIterator.isDone("Bands"))
                {
                    if (cIterator.currentItem("Bands") == "Linkin Park")
                    {
                        lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                        cIterator.next("Bands");
                    }
                    else
                        cIterator.next("Bands");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }

        private void riseAgainst_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (riseAgainst_rbtn.Checked == true)
            {
                cIterator.first("Bands");

                while (!cIterator.isDone("Bands"))
                {
                    if (cIterator.currentItem("Bands") == "Rise Against")
                    {
                        lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                        cIterator.next("Bands");
                    }
                    else
                        cIterator.next("Bands");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }

        private void threeDaysGrace_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (threeDaysGrace_rbtn.Checked == true)
            {
                cIterator.first("Bands");

                while (!cIterator.isDone("Bands"))
                {
                    if (cIterator.currentItem("Bands") == "Three Days Grace")
                    {
                        lbDisplay.Items.Add(cIterator.currentItem("Albums"));
                        cIterator.next("Bands");
                    }
                    else
                        cIterator.next("Bands");
                }
            }
            else
            {
                lbDisplay.Items.Clear();
            }
        }
    }
}
