namespace Kivetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kivételek");

            try
            {
                Console.Write("Adjon meg egy számot:");
                int szam = Convert.ToInt32(Console.ReadLine());

                try
                {
                    throw new ArithmeticException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("A megadott érték nem megfelelő");                     
                }
                    
                
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("A megadott érték túl nagy!");
            }
            catch (FormatException ex) {

                Console.WriteLine("Számot kell megadni!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                
            }
            finally
            {
                //Console.WriteLine("Az itt lévő kód akkor is végrehajtódik, ha nem volt kivétel");
            }

            Console.WriteLine("Folytatódik tovább a program");


        }
    }
}
