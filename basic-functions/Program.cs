using System.Diagnostics.CodeAnalysis;

int sum (int first, int second)
{
  return first + second;
}

void print_sudoku (int[][]puzzle)
{
  Console.WriteLine("");
  for (int i = 0; i < puzzle.Length; i++)
  {
    if (i != 0 && i % 3 == 0)
    {
      Console.WriteLine("___________________");
    }
    for (int j = 0; j < puzzle[i].Length; j++)
    {
      if (j != 0 && j % 3 == 0)
      {
        Console.Write("|");
      }
      Console.Write("{0} ", puzzle[i][j]);

    }
    Console.Write("\n");
  }
  Console.WriteLine("");
}


void puzzle_game()
{
  int[][] puzzle = [
    [7, 3, 6, 4, 5, 2, 9, 8, 1],
    [1, 9, 8, 6, 3, 7, 4, 5, 2],
    [4, 2, 5, 9, 8, 1, 3, 7, 6],
    [3, 6, 4, 5, 2, 8, 1, 9, 7],
    [9, 5, 2, 7, 1, 4, 6, 3, 8],
    [8, 1, 7, 3, 9, 6, 2, 4, 5],
    [2, 8, 9, 1, 7, 3, 5, 6, 4],
    [6, 7, 3, 2, 4, 5, 8, 1, 9],
    [5, 4, 1, 8, 6, 9, 7, 2, 3],
  ];
  
  print_sudoku(puzzle);
}

int rec_factorial (int num)
{
  if (num == 1)
  {
    return 1;
  }
  return num * rec_factorial(num - 1);
}

// Console.WriteLine(rec_factorial(5));

void print_circle_properties (float r)
{
  Console.WriteLine("Radius of a circle is " + r);
  Console.WriteLine($"Area of the circle is {Math.Round(r * r * Math.PI, 3)}");
  Console.WriteLine($"Circumference of the circle is {Math.Round(2 * r * Math.PI, 3)}\n");

}

// print_circle_properties(1);
// print_circle_properties(3);
// print_circle_properties(5);

double get_sqrt(float input, int decimals)
{
  return Math.Round(Math.Sqrt(input), decimals);
}

// Console.WriteLine(get_sqrt(14.28f, 3));

puzzle_game();