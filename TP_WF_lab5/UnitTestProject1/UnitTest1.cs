using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_WF_lab5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
            Assert.AreEqual(kek.dataGridView1.Rows[0].Cells[1].Value, 43);
        }
        [TestMethod]
        public void TestMethod2()
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
            Assert.AreEqual(kek.dataGridView1.Rows[2].Cells[1].Value, 21);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Form1 kek = new Form1();
            kek.dataGridView1.Rows.Add(0, 23);
            kek.dataGridView1.Rows.Add(0, 21);
            kek.dataGridView1.Rows.Add(0, 2);
            kek.dataGridView1.Rows.Add(0, 43);
            kek.dataGridView1.Rows.Add(0, 12);
            kek.comboBox1.SelectedIndex = 0;
            kek.Chart();
            Assert.AreEqual(kek.frm2.chart1.Titles[0].DockingOffset, 0);
        }
    }
}
