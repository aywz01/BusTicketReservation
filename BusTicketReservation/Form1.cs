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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Places myplaces =new Places(); 
            for(int i = 0; i < myplaces.city1.Length; i++)
            {
                comboBox1.Items.Add(myplaces.city1[i]);
            }

            for (int i = 0; i < myplaces.city1.Length; i++)
            {
                comboBox2.Items.Add(myplaces.city1[i]);
            }

  
        }
        

       
        //METHOD//
        public void DateNTime()
        {
            //DateTimeStruct//
            DateTime dt2 = new DateTime(2021, 06, 06, 0, 0, 0);
            DateTime dt1 = dateTimePicker1.Value;
            int result = dt1.CompareTo(dt2);
            if (result == 0)
            {
                Places myplaces = new Places();
               string a= myplaces.BusName(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                textBox1.Text = a;
            }
            else
            {
                textBox1.Text = "no bus in this date";
                MessageBox.Show("nearest date :06.06.2021");
            }

        }
            private void button1_Click(object sender, EventArgs e)
            {
                DateNTime();

            }
        

        private void button2_Click(object sender, EventArgs e)
        {
 
            Form2 form2 = new Form2();
            form2.Show();
            form2.a = textBox1.Text;

           

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
           

            if (comboBox3.SelectedItem != "")
            { 
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
            }
            else if (comboBox4.SelectedItem != "")
            {
                comboBox3.Enabled = false;
                comboBox5.Enabled = false;
            }
            else if (comboBox5.SelectedItem != "") ;
            {
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }



            string a = textBox1.Text;
            string one = "Bus:ATOAN1 at:13.00";
            string one1 = "Bus:ATOB2 at:13.30";
            string one2 = "Bus:ATOG3 at:13.50";
            string one3 = "Bus:ATOİ4 at:13.20";

            if (a == one) textBox2.Text = "30TL";
            if (a == one1) textBox2.Text = "30TL";
            if (a == one2) textBox2.Text = "30TL";
            if (a == one3) textBox2.Text = "30TL";

            
            string two = "Bus:ANTOA1 at:14.00";
            string two1 = "Bus:ANTOB2 at:14.40";
            string two2 = "Bus:ANTOG3 at:14.10";
            string two3 = "Bus:ANTOİ4 at:14.50";

            if (a == two) textBox2.Text = "40TL";
            if (a == two1) textBox2.Text = "40TL";
            if (a == two2) textBox2.Text = "40TL";
            if (a == two3) textBox2.Text = "40TL";

            string three = "Bus:BTOA1 at:15.30";
            string three1 = "Bus:BTOAN2 at:15.00";
            string three2 = "Bus:BTOG3 at:15.50";
            string three3 = "Bus:BTOİ4 at:15.20";

            if (a == three) textBox2.Text = "35TL";
            if (a == three1) textBox2.Text = "35TL";
            if (a == three2) textBox2.Text = "35TL";
            if (a == three3) textBox2.Text = "35TL";

            string four = "Bus:GTOA1 at:16.10";
            string four1 = "Bus:GTOAN2 at:16.20";
            string four2 = "Bus:GTOB3 at:16.50";
            string four3 = "Bus:GTOİ4 at:16.45";

            if (a == four) textBox2.Text = "25TL";
            if (a == four1) textBox2.Text = "25TL";
            if (a == four2) textBox2.Text = "25TL";
            if (a == four3) textBox2.Text = "25TL";

            string five = "Bus:İTOA1 at:17.35";
            string five1 = "Bus:İTOAN2 at:17.00";
            string five2 = "Bus:İTOB3 at:17.05";
            string five3 = "Bus:İTOG4 at:17.30";

            if (a == five) textBox2.Text = "45TL";
            if (a == five1) textBox2.Text = "45TL";
            if (a == five2) textBox2.Text = "45TL";
            if (a == five3) textBox2.Text = "45TL";
   
        }

      
    }
    
}
