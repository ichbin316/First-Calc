namespace Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool progoff = true;

            int n1 = 0;

            int n2 = 0;

            int result;

            while (progoff == true) {


                Console.Write("Welcome to Calculator \n");

                Console.ReadKey();

                Console.Write("(1) multiply \n(2) Divide \n(3) Add \n(4) Subtract \n(end) End program \n");

              

                String math = Console.ReadLine();

                
                Console.Clear();


                switch (math)
                {   
                    case "end":
                        Console.ReadKey(progoff = false);
                        return;

                    case "1":
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine(result + "\n");
                        break;

                    case "2":
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 / n2;
                        Console.Write(result + "\n");
                        break;

                    case "3":
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 + n2;
                        Console.Write(result + "\n");
                        break;

                    case "4":
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 - n2;
                        Console.Write(result + "\n");
                        break;
                }

                


            }






        }
    }
}
