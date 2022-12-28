using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Egzersiz
{
    internal class clsInsan
    {
        public string ad { get; set; }
        public string soyad { get; set; }

        public int yas { get; set; }

        public int boy { get; set; }

        public int kilo { get; set; }


  
        public clsInsan()
        {
            ad = "Gamze";
            soyad = "Kara";
            yas = 25;
            boy = 164;
            kilo = 55;

                        
        }

        public void Tanis()
        {
            Console.WriteLine("\n Adım : {0}  \n Soyadım {1} \n Yasım {2} \n Boyum {3} \n Kilom {4}",ad,soyad,yas,boy,kilo);
           
        }
            
    }
}
