namespace välj_nummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nummer = 0;

            while (nummer < 1 || nummer > 3 && nummer != 99)
            {


                Console.Write("Välj nummer 1-3 eller 99 för att sluta: ");
                try
                {
                    nummer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.ToString());
                    nummer = 0;
                    Console.WriteLine(e.Message);
                    //if (e = ) ;
                    //break;
                }
            }

            switch (nummer)
            {
                case 1:
                    Console.WriteLine("Du valde nummer ett ");
                    break;

                case 2:
                    Console.WriteLine("Du valde nummer två ");
                    break;

                case 3:
                    Console.WriteLine("Du valde nummer tre ");
                    break;

                 case 99:
                    Console.WriteLine("Du valde att sluta");         
                    break;
            }





        }
    }
}