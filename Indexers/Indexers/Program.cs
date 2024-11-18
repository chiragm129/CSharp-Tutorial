using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    //what are indexers
    //if we want which type of data will go in array, list, collection for encapsulated so will use Indexers

    class Empployee
    {
        private int[] Age = new int[3];

        public int this[int index]//no namr of this ptoprty
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {

                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("dont put neg and zero");
                    }
                }
                else
                {
                    Console.WriteLine("invald index");
                }
            }
            get
            {
                return Age[index];
            }

        }
        public int this[int index, int i]//here we overloading of indexersy
        {
            set
            {
                Age[index] = value + i;
            }

            get
            {
                return Age[index];
            }

        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Empployee e = new Empployee();
                //for 1st indexer
                // e[0] = 5;//here object will work as indexers
                //e[0] = -5;//dont put neg & zero conditon
                // e[4] = 5;//index invalid conditione

                // Console.WriteLine(e[0]); 

                //for 2nd indexer
                e[0, 1] = 5;
                Console.WriteLine(e[0, 1]);

                Console.ReadLine();

            }
        }
    }
