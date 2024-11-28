namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] ints = new int[15];
            double[] doubles = new double[15];

           
            for (int i = 0; i < ints.Length; i++)
                ints[i] = rand.Next(0, 10);
            for (int i = 0; i < doubles.Length; i++)
                doubles[i] = rand.NextDouble() * 10;

            
            Console.WriteLine("\nTablica liczb całkowitych przed sortowaniem\n");
            foreach (int i in ints)
                Console.Write(i + ", ");
            Console.WriteLine();

            Console.WriteLine("\nTablica liczb zmiennoprzecinkowych przed sortowaniem\n");
            foreach (double i in doubles)
                Console.Write(i + ", ");
            Console.WriteLine();


            Console.WriteLine("\nTablica liczb calkowitych po posortowaniu\n");
            foreach (int i in Sort(ints))
                Console.Write(i + ", ");
            Console.WriteLine();

            Console.WriteLine("\nTablica liczb zmiennoprzecinkowych po posortowaniu\n");
            foreach (double i in Sort(doubles))
                Console.Write(i + ", ");
            Console.WriteLine();
        }

        
        static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
