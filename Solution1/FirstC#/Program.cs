namespace FirstC_
{
    internal class Program
    {
        public static void SimpleHollowDiamond(int size)
        {
            Console.WriteLine("Simplified Hollow Diamond Pattern:");

            int totalRows = 2 * size - 1;
            int centerRowIndex = size;
            for (int i = 1; i <= totalRows; i++){
                int distance = Math.Abs(i - centerRowIndex);
                int outerSpace = distance;
                for (int j = 1; j <= outerSpace; j++){
                    Console.Write(" ");
                }
                Console.Write("*");
                int innerSpace = (2 * (size - distance) - 3);
                if (i != 1 && i != totalRows)
                {
                    for (int k = 1; k <= innerSpace; k++){
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            SimpleHollowDiamond(4);
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("second line");
            //Console.WriteLine("     *      ");
            //Console.WriteLine("  *     *   ");
            //Console.WriteLine("*         * ");
            //Console.WriteLine("  *     *   ");
            //Console.WriteLine("     *      ");

           

    }
}


}
