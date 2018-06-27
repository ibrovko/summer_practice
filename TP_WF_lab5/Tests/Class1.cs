using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TP_WF_lab5;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Form1 kek = new Form1();
            kek.dataGridView1.Rows.Add(0, 23);
            kek.dataGridView1.Rows.Add(0, 21);
            kek.dataGridView1.Rows.Add(0, 2);
            kek.dataGridView1.Rows.Add(0, 43);
            kek.dataGridView1.Rows.Add(0, 12);
            object sender = 0;
            EventArgs e = new EventArgs();
            kek.button_sort(sender, e);
            Assert.That(kek.dataGridView1.Rows[0].Cells[1].Value, Is.EqualTo(43));
        }
        [Test]
        public void Test2()
        {
            Form1 kek = new Form1();
            kek.dataGridView1.Rows.Add(0, 23);
            kek.dataGridView1.Rows.Add(0, 21);
            kek.dataGridView1.Rows.Add(0, 2);
            kek.dataGridView1.Rows.Add(0, 43);
            kek.dataGridView1.Rows.Add(0, 12);
            object sender = 0;
            EventArgs e = new EventArgs();
            kek.button_sort(sender, e);
            Assert.That(kek.dataGridView1.Rows[0].Cells[1].Value, Is.EqualTo(43));
        }
        [Test]
        public void Test3()
        {
            Form1 kek = new Form1();
            kek.dataGridView1.Rows.Add(0, 23);
            kek.dataGridView1.Rows.Add(0, 21);
            kek.dataGridView1.Rows.Add(0, 2);
            kek.dataGridView1.Rows.Add(0, 43);
            kek.dataGridView1.Rows.Add(0, 12);
            kek.comboBox1.SelectedIndex = 0;
            kek.Chart();
            Assert.That(kek.frm2.chart1.Titles[0].DockingOffset, Is.EqualTo(0));
        }
    }
}