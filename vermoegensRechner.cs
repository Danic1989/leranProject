using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        

        //vermoegensRechner!!
        public static void Main(string[] args)
        {
            vermoegenUndKaufkraftBerechnung();
            Console.ReadLine();
        }
        public static void vermoegenUndKaufkraftBerechnung()
        {

            double[] vermoegenArray = new double[31];
            double kaufkraft = 0;
            vermoegenArray[0] = 0;

            Console.WriteLine("Wieviel möchtest du monatlich einzahlen?");
            string eingabeInvestition = Console.ReadLine();
            int investiton = Int32.Parse(eingabeInvestition);
            double jaehrlicheInvestition = Convert.ToDouble(investiton) * 12;



            for(int i = 1; i <=30; i++)
            {
                vermoegenArray[i] = (vermoegenArray[i - 1] + jaehrlicheInvestition) * 1.07;
            }

            Console.WriteLine("Wie viele Jahre in die Zukunft möchtest du dein Vermögen berechnen");
            string jahreInZukunft = Console.ReadLine();
            int jahreInt = Int32.Parse(jahreInZukunft);

            kaufkraft = vermoegenArray[jahreInt] * (1 / (Math.Pow((1.025), jahreInt)));
            Console.WriteLine("Dein Vermögen nach " + jahreInZukunft + " Jahren wird {0:0.00}  Euro sein.", vermoegenArray[jahreInt]);
            Console.WriteLine("Deine Kaufkrat nach " + jahreInZukunft + " Jahren wird {0:0.00}  Euro sein.", kaufkraft);
            Console.WriteLine("Drücke die Enter, um das Programm zu schließen!");
            

        }
      
      }

    }

