using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketReservation
{
    class Customer //3rdCLASS//
    {
        private string name;
        private string surname;
        private string phone;
        private string id;
        private string mail;
        private string card;
        private string gender;


        public string Name
        {
            //STRINGFUNCTION//
            get{return name.ToUpper();}
            set{name= value;}
        }

        public string Surname
        {
            get { return surname.ToUpper(); }
            set { surname = value; }
        }

        public string PhoneNum
        {
            get { return phone; }
            set { phone = value; }
        }

        public string IdNum
        {
            get { return id; }
            set {
                if (value.Length == 11)
                    id = value;
                else
                    MessageBox.Show("please enter 11 element to id number");
            }
        }

        public string Email
        {
            get { return mail; }
            set { mail = value; }
        }

        public string CardNum
        {
            get { return card; }
            set { card = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

    }
}
