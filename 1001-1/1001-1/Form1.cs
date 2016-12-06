using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myFunction;

namespace _1001_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        Function myfunction = new Function();

        int[] myArray = new int[30];
        string[] myStringArray = new string[] {
            "gibson",
            "johnson",
            "allahu akbar",
            "many",
            "cyka",
            "rich",
            "hello",
            "zoo",
            "ll",
            "eig"
            };
        bool bigtosmall = false; 

        private void Form1_Load(object sender, EventArgs e) {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e) {
            for (int i = 0; i <= myArray.Length - 1; i++) {
                myArray[i] = myfunction.RandomNumber(100);
            }
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox2.DataSource = myArray;
            listBox1.DataSource = myfunction.SortTheArray(myArray, bigtosmall);
            listBox3.DataSource = myfunction.SortTheArray(myStringArray, bigtosmall);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                bigtosmall = true;
            }
            else {
                bigtosmall = false;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = myfunction.SortTheArray(myArray, bigtosmall);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
