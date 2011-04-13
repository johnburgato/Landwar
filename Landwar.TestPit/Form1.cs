using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Landwar.Data;

namespace Landwar.TestPit
{
    public partial class Form1 : Form
    {
        HeXnaEntities dataContext = null;

        public Form1()
        {
            InitializeComponent();

            dataContext = new HeXnaEntities();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            MAP m;
            if (!dataContext.MAP.Any())
            {
                m = new MAP() { NAME = "New map", DESCRIPTION = "Map of doom" };
                dataContext.AddToMAP(m);
            }
            else
            {
                m = dataContext.MAP.First();
            }

            HEX lastHex = (from h in dataContext.HEX
                           select h).OrderByDescending(h => h.Y).FirstOrDefault();
            HEX newHex = new HEX() { TERRAIN_ID = 1, HEIGHT = 0 };
            if (lastHex == null)
            {
                newHex.X = 0; newHex.Y = 0;
            }
            else
            {
                newHex.X = 0; newHex.Y = lastHex.Y + 1;
            }

            m.HEXES.Add(newHex);

            dataContext.SaveChanges();

            txtOutput.AppendText("Hex " + newHex.ID + " added");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            MAP m = dataContext.MAP.FirstOrDefault();
            if (m == null)
            {
                txtOutput.AppendText("No map" + Environment.NewLine);
            }
            else
            {
                txtOutput.AppendText("Map: " + m.ID + " - " + m.NAME + Environment.NewLine);

                List<HEX> hexes = (from h in dataContext.HEX
                                   where h.MAP.ID == m.ID
                                   select h).ToList();
                foreach (HEX h in hexes)
                {
                    txtOutput.AppendText("Hex: " + h.ID + " - " + h.Y + Environment.NewLine);
                }
            }
        }
    }
}
