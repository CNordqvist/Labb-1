while (true)
{

    Random random = new Random();
    string line = "29535123p48723487597645723645";
    char input;
    double sum = 0;

    //användar meny
    Console.WriteLine("\nVill du göra en egen string? y/n. s för stop");
    char.TryParse(Console.ReadLine(), out input);

    if (input == 'y')
    {
        Console.WriteLine("Var god och skriv in den sträng du vill använda");
        line = Console.ReadLine();
    }
    else if (input == 's')
    {
        break;
    }
    else if (input != 'n')
    {
        Console.WriteLine("Unrecognized character");
        continue;
    }


    for (int i = 0; i < line.Length - 1; i++)
    {
        int color = random.Next(4);
        string lineNums = "";

        if (!char.IsDigit(line[i]))
        {
            continue;
        }

        for (int j = i + 1; j < line.Length; j++)
        {
            if (!char.IsDigit(line[j]))
            {
                break;
            }

            //hitta sista siffran i ett tal som stämmer med kriterierna, printa linjen
            else if (line[j] == line[i])
            {
                for (int l = 0; l < line.Length; l++)
                {
                    if (l >= i && l <= j)
                    {
                        lineNums += line[l];
                        ColorSwitch(color);
                        Console.Write(line[l]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(line[l]);
                    }

                }
                sum += double.Parse(lineNums);
                Console.WriteLine("");
                break;
            }

        }
    }
    Console.WriteLine("\nAll the colored numbers add up to: " + sum);
}

ConsoleColor ColorSwitch(int color)
{
    switch (color)
    {
        case 0:
            return Console.ForegroundColor = ConsoleColor.Green;
        case 1:
            return Console.ForegroundColor = ConsoleColor.DarkRed;
        case 2:
            return Console.ForegroundColor = ConsoleColor.Magenta;
        case 3:
            return Console.ForegroundColor = ConsoleColor.Blue;
        default:
            return Console.ForegroundColor = ConsoleColor.Red;
    }
}