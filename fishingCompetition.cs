namespace SoftUni_CSharpAdvancedExamPrep1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int sailorRow = 0;
            int sailorCol = 0;
            for(int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                    if(matrix[i, j] == 'S')
                    {
                        sailorRow = i;
                        sailorCol = j;
                    }
                }
            }

            int tonsOfFishCaught = 0;
            string direction = Console.ReadLine();
            while(direction != "collect the nets")
            {
                switch(direction)
                {
                    case "up":
                        matrix[sailorRow, sailorCol] = '-';
                        sailorRow--;
                        if(sailorRow == -1) sailorRow = n - 1;
                        if(matrix[sailorRow, sailorCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish" +
                                $" you caught. Last coordinates of the ship: [{sailorRow},{sailorCol}]");
                            return;
                        }
                        if(char.IsDigit(matrix[sailorRow, sailorCol]))
                        {
                            tonsOfFishCaught += matrix[sailorRow, sailorCol] - '0';
                        }
                        matrix[sailorRow, sailorCol] = 'S';
                        break;
                    case "right":
                        matrix[sailorRow, sailorCol] = '-';
                        sailorCol++;
                        if(sailorCol == n) sailorCol = 0;
                        if(matrix[sailorRow, sailorCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish" +
                                $" you caught. Last coordinates of the ship: [{sailorRow},{sailorCol}]");
                            return;
                        }
                        if(char.IsDigit(matrix[sailorRow, sailorCol]))
                        {
                            tonsOfFishCaught += matrix[sailorRow, sailorCol] - '0';
                        }
                        matrix[sailorRow, sailorCol] = 'S';
                        break;
                    case "down":
                        matrix[sailorRow, sailorCol] = '-';
                        sailorRow++;
                        if(sailorRow == n) sailorRow = 0;
                        if(matrix[sailorRow, sailorCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish" +
                                $" you caught. Last coordinates of the ship: [{sailorRow},{sailorCol}]");
                            return;
                        }
                        if(char.IsDigit(matrix[sailorRow, sailorCol]))
                        {
                            tonsOfFishCaught += matrix[sailorRow, sailorCol] - '0';
                        }
                        matrix[sailorRow, sailorCol] = 'S';
                        break;
                    case "left":
                        matrix[sailorRow, sailorCol] = '-';
                        sailorCol--;
                        if(sailorCol == -1) sailorCol = n - 1;
                        if(matrix[sailorRow, sailorCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish" +
                                $" you caught. Last coordinates of the ship: [{sailorRow},{sailorCol}]");
                            return;
                        }
                        if(char.IsDigit(matrix[sailorRow, sailorCol]))
                        {
                            tonsOfFishCaught += matrix[sailorRow, sailorCol] - '0';
                        }
                        matrix[sailorRow, sailorCol] = 'S';
                        break;
                }
                direction = Console.ReadLine();
            }

            if(tonsOfFishCaught >= 20) Console.WriteLine("Success! You managed to reach the quota!");
            else Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! " +
                $"You need {20 - tonsOfFishCaught} tons of fish more.");

            if(tonsOfFishCaught > 0) Console.WriteLine($"Amount of fish caught: {tonsOfFishCaught} tons.");

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}