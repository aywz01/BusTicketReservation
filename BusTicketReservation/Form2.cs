using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketReservation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public string a;

        private void button2_Click(object sender, EventArgs e)
        {
            Customer mycustomer = new Customer();
            mycustomer.Name = textBox1.Text;
            mycustomer.Surname = textBox2.Text;
            mycustomer.PhoneNum = textBox3.Text;
            mycustomer.IdNum =  textBox5.Text;
            mycustomer.Email = textBox6.Text;
            mycustomer.CardNum = textBox4.Text;
            mycustomer.Gender = comboBox1.SelectedIndex.ToString();

            
            
            MessageBox.Show("Ticket Information \n"+"name:"+mycustomer.Name+ "\n"+"Surname:"+ mycustomer.Surname
                +"\n"+a);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("payment completed!");
            
            this.Close();
        }
    }
}
