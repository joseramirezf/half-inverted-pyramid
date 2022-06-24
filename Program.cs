Console.WriteLine("Half Inverted Numeric Pyramid");

Console.WriteLine("Enter a Number of Rows");

int number = Int32.Parse(Console.ReadLine() ?? "n");

Console.WriteLine("Final Pyramid:");

for (int i = number; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


Console.WriteLine("End Program");