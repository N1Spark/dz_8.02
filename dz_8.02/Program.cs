using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_8._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Credit credit_card = new Credit();
            try
            {
                Console.Write("Введите номер карты: ");
                credit_card.Num_Card = Console.ReadLine();
                if(credit_card.Num_Card.Length < 16 || credit_card.Num_Card.Length >16)
                {
                    throw new Exception("Номер карты должен состоять из 16 чисел!");
                }
                else if(credit_card.Num_Card.IndexOf(" ") != -1)
                {
                    throw new Exception("В номере не должно быть пробелов!");
                }

                Console.Write("Введите ФИО: ");
                credit_card.name = Console.ReadLine();
                if(credit_card.name == "")
                {
                    throw new Exception("Неправильное ФИО!");
                }

                Console.Write("Введите CVC: ");
                credit_card.CVC = Convert.ToInt32(Console.ReadLine());
                if(credit_card.CVC.ToString().Length < 3 || credit_card.CVC.ToString().Length > 3)
                {
                    throw new Exception("В CVC должно быть 3 числа!");
                }

                Console.Write("Введите срок карты: ");
                credit_card.Data_End = Console.ReadLine();

                Console.WriteLine("\n"+credit_card);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }
            
        }
    }
}
