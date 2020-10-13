using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićNasljeđivanje
{
    class Program
    {
        interface IControl
        {
            void Metoda();
            int Brojac { get; set; }
        }
      
        class ComboBox : IControl
        {
            private int brojac;

            public int Brojac { get => brojac; set => brojac = value; }

            public void Metoda()
            {
                Console.WriteLine("Metoda kombo");
            }
        }
        class ListBox : IControl
        {
            private int brojac;

            public int Brojac { get => brojac; set => brojac = value; }

            public void Metoda()
            {

                Console.WriteLine("Metoda list");
            }
        }
        static void Main(string[] args)
        {

            ListBox x = new ListBox();
            ComboBox y = new ComboBox();
            x.Metoda();
            y.Metoda();
            Console.ReadKey();

        }

    }
    }

