using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Calculatrice Console");
                Console.WriteLine("1. somme");
                Console.WriteLine("2.Soustraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Diviser");
                Console.WriteLine("5.Quitter");
                Console.Write("(1-5) Entre l'opération souhaitée :");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Quitter");
                    break;
                }

                Console.WriteLine("Entre Numb1");
                double Numb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Entre Numb2");
                double Numb2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Numb1 + Numb2;
                        break;
                    case 2:
                        result = Numb2 - Numb1;
                        break;
                    case 3:
                        result = Numb1 * Numb2;
                        break;
                    case 4:
                        result = Numb1 / Numb2;
                        break;
                    default: Console.WriteLine("(1-5) Entre l'opération souhaitée :");
                        continue;
                }
                Console.WriteLine("Result : " + result);

                                    
            }
            catch (Exception)
            {
                Console.WriteLine("erreur : entre un valide Numb");
            }

            
        }


    }
}
