using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{

        public class Araba
        {
            public string marka;
            public string model;
            public string renk;
            private int kapı_sayısı;


            public int Kapı_Sayısı
            {
                get { return kapı_sayısı; }
                set
                {
                    if (value != 2 && value != 4)
                    {
                        Console.WriteLine("Geçerli olmayan kapı sayısı girdiniz!");
                        kapı_sayısı = -1;

                    }
                    else kapı_sayısı = value;



                }

            }



        }


  
}

