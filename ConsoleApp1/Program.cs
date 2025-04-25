using tydz4_lek13;


namespace MyApp
{
    internal class Program
    {
        /*
            Napisz aplikację, grę FizzBuzz. Gra ta na podstawie przekazanej liczby zwraca odpowiedni wynik.
            Zasady gry:
            -Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.
            -Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.
            -Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”.
            -Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.
            Niech to będzie nowa metoda niestatyczna w osobnej klasie o nazwie FizzBuzz. Najlepiej jak sama metoda będzie zwracała string’a,
            który zostanie zwrócony i wyświetlony w klasie Program w metodzie Main.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Program to prosta gra FizzBuzz.\n");

            int userNumber = 0;
            bool isNumberOk, playAgain;
            string select = "T";
            FizzBuzz fizzBuzz = new FizzBuzz();

            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Podaj liczbę całkowitą:");
                        isNumberOk = GetNumber(out userNumber);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        isNumberOk = false;
                    }
                } while (!isNumberOk);

                Console.Clear();
                Console.WriteLine($"Twój wynik to {fizzBuzz.resultFizzBuzz(userNumber)}");
                
                do
                {
                    try
                    {
                        Console.WriteLine("\nCzy chcesz zagrać ponownie? Wpisz [T/t] jeśli TAK lub [N/n] jeśli NIE.\n");
                        playAgain = GetChoice(out select);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        playAgain = false;
                    }
                } while (!playAgain);

                Console.Clear();
            } while ((select.Equals("T") || select.Equals("t")));

            Console.WriteLine("\nDziękuję za grę i do następnego razu :)");
    
            
            static bool GetNumber(out int number)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                    return true;
                else
                    throw new Exception("Nie podałeś prawidłowej liczby! Spróbuj ponownie.\n");
            }

            static bool GetChoice(out string select)
            {
                select = Console.ReadLine();

                if (select.Equals("T", StringComparison.OrdinalIgnoreCase)
                    || select.Equals("N", StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    throw new Exception("Nie podałeś prawidłowej wartości [T/t] lub [N/n]!");
            }
        }
    }
}


