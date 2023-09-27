namespace ToDo
{
    internal class Program
    {
        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
        }

        static void squareRef(ref int refParameter) 
        {
            refParameter *= refParameter;
        }

        static void Main(string[] args)
        {
            int arg;
            arg = 4;
            squareVal(arg);
            Console.WriteLine(arg);
            arg = 4;
            squareRef(ref arg);
            Console.WriteLine(arg);
        }
    }
}