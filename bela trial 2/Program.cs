using System;

public class bela
{
    public static void Main(string[] args)
    {
        // declare class
        string line = Console.ReadLine();
        int space = line.IndexOf(' ');
        int hands = int.Parse(line.Substring(0, space)) * 4;
        char suit = line[space + 1];
        int points = 0;
        for (int x = 0; x < hands; x++)
       

            // declare point values to fit the Kattis Bela model 
        {
            string s = Console.ReadLine();
            switch (s[0])
            {
                case 'A':
                    points += 11;
                    break;
                case 'K':
                    points += 4;
                    break;
                case 'Q':
                    points += 3;
                    break;
                case 'J':
                    if (s[1] == suit)
                        points += 20;
                    else
                        points += 2;
                    break;
                case 'T':
                    points += 10;
                    break;
                case '7':
                    points += 0;
                    break;
                case '8':
                    points += 0;
                    break;

                case '9':
                    if (s[1] == suit)
                        points += 14;

                    //case 7 and case 8 points are equal to zero. ignore for Kattis right now

                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(points);
    }
}