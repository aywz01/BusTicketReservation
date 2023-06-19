using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusTicketReservation
{
    class Places:Busses //INHERITANCE//
    {
        private string City1go;
      
        private string City1come;
        

        public string[] city1 = { "adana", "ankara", "bursa", "gaziantep", "istanbul" };
        public string[] city2 = { "ankara", "adana", "bursa", "gaziantep", "istanbul" };
        public string[] city3 = { "bursa", "adana", "ankara", "gaziantep", "istanbul" };
        public string[] city4 = { "gaziantep", "adana", "ankara", "bursa", "istanbul" };
        public string[] city5 = { "istanbul", "adana", "ankara", "bursa", "gaziantep" };

        
        public string BusName(string go, string come)
        {
            City1go = go;
            City1come = come;
            
           
            if (City1go == city1[0] )
            {
                for (int i = 0; i < 4; i++)
                {
                    if (City1come == city1[i+1])
                    {
                        bus = busnames1[i];
                    }
                }
                
            }

            else if (City1go == city2[0])
            {
                for (int i = 0; i < 4; i++)
                {
                    if (City1come == city2[i + 1])
                    {
                        bus = busnames2[i];
                    }
                }
            }

            else if (City1go == city3[0])
            {
                for (int i = 0; i < 4; i++)
                {
                    if (City1come == city3[i + 1])
                    {
                        bus = busnames3[i];
                    }
                }
            }

            else if (City1go == city4[0])
            {
                for (int i = 0; i < 4; i++)
                {
                    if (City1come == city4[i + 1])
                    {
                        bus = busnames4[i];
                    }
                }
            }

            else if (City1go == city5[0])
            {
                for (int i = 0; i < 4; i++)
                {
                    if (City1come == city5[i + 1])
                    {
                        bus = busnames5[i];
                    }
                }
            }

            if (City1go == City1come)
            {
                MessageBox.Show("please select another city");
            }

            return bus;
        }

    }
}
