using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /*Show money on the screen with Button Click*/
        int money = 10;

        public int UsingThis(int money)
        {
            this.money = this.money * money;
            return this.money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Value is :" + UsingThis(10));
        }





        /*Show total age of 3 person - method that does not return a value*/

        public void showAges(int age1, int age2, int age3)
        {
            int totalAge = age1 + age2 + age3;
            MessageBox.Show("Total age : " + totalAge);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            showAges(20,50,40);
        }




        /*methods that return values*/
        public int returnValueMethod(int a , int b)
        {
            int result = a * b;
            return result; // this line is return value
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(returnValueMethod(3, 9).ToString());
        }
        
        



        /*REF OUT*/

        public int refPassValue(ref int value)
        {
            value = 100;
            return value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 1;
            MessageBox.Show("Before calling: " + a.ToString());
            refPassValue(ref a);
            MessageBox.Show("After calling: " + a.ToString());
        }

        public int outPassValue(out int value)
        {
            value = 100;
            return value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            outPassValue(out a);
            MessageBox.Show("After calling method: " + a.ToString());
        }





        /*Find biggest number*/
        public int findBiggestNumber(params int[] allNumbers)
        {
            int biggestNumber = -1;


            if (allNumbers.Length > 0)
                biggestNumber = allNumbers[0];

            for(int i = 0; i < allNumbers.Length; i++)
            {
                if (biggestNumber < allNumbers[i])
                    biggestNumber = allNumbers[i];  
            }
            return biggestNumber;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The biggest number is: " + findBiggestNumber(1, 5, 3, 9, 20, 60));
        }




    }
}
