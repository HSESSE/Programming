using System;
class Program
{
    public static void Main()
    {
        int n1 = 2000;
        int n2 = 3000;
        string n_str;

        while (n1 <= n2)
        {
            n_str = Convert.ToString(n1);
            int count = 1;
            bool f = true;
            for (int i = 0; i < n_str.Length; i++)
            {
                for (int j = 0; j < n_str.Length; j++)
                {
                    if (i != j)
                    {
                        if (n_str[i] == n_str[j])
                        {
                            count += 1;
                        }
                    }
                }
                if (count == 2)
                {
                    f = false;
                    break;
                }
                count = 1;
            }
            if (f)
            {
                Console.WriteLine(n1);
            }

            n1 += 1;
        }
    }
}