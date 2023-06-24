using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int height = Convert.ToInt32(Console.ReadLine());

        DrawTriangle(height);
    }

    static void DrawTriangle(int height)
    {
        int width = 1;
        int spaces = height - 1;

        for (int i = 0; i < height; i++)
        {
            PrintSpaces(spaces);
            PrintPluses(width);

            Console.WriteLine();

            width += 2;
            spaces--;
        }
    }

    static void PrintSpaces(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(" ");
        }
    }

    static void PrintPluses(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("+");
        }
    }
}
