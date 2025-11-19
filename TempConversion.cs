namespace Yes;

class Program
{
    public static void CheckString(string checkedString, string invalidInput)
    {
        try
        {
            int intTest = Int32.Parse(checkedString);
        }
        catch (FormatException)

        {
            Console.WriteLine(invalidInput);
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

    }
    static void Main()
    {
        string invalidInput = "Invalid input, bye bye";
        int[] validIntegers = [1, 2, 3, 4, 5, 6];
        Console.WriteLine("This program is for general temperature conversion. Please enter the number corresponding to the conversion you'd like:");
        Console.WriteLine("1 : Fahrenheit to Celsius");
        Console.WriteLine("2 : Fahrenheit to Kelvin");
        Console.WriteLine("3 : Celsius to Fahrenheit");
        Console.WriteLine("4 : Celsius to Kelvin");
        Console.WriteLine("5 : Kelvin to Fahrenheit");
        Console.WriteLine("6 : Kelvin to Celsius" + Environment.NewLine);


        string conversion = Console.ReadLine();

        CheckString(conversion, invalidInput);

        int intConversion = Int32.Parse(conversion);

        if (validIntegers.Contains(intConversion) == false)
        {
            Console.WriteLine(invalidInput);
            return;
        }
        Console.WriteLine("Now type the temperature number to convert");

        string stringTemp = Console.ReadLine();

        CheckString(stringTemp, invalidInput);

        Decimal decTemp = Convert.ToInt32(stringTemp);
        int intTemp = Convert.ToInt32(Math.Round(decTemp, 3));


        switch (intConversion)
        {
            case 1:
                Console.WriteLine("Converting to Celsius gives: " + (intTemp - 32) / (1.8));
                break;
            case 2:
                Console.WriteLine("Converting to Kelvin gives: " + (intTemp - 32) / (1.8) + 273.15);
                break;
            case 3:
                Console.WriteLine("Converting to Fahrenheit gives: " + (intTemp * (9 / 5) + 32));
                break;
            case 4:
                Console.WriteLine("Converting to Kelvin gives: " + (intTemp + 273.15));
                break;
            case 5:
                Console.WriteLine("Converting to Fahrenheit gives: " + ((intTemp * 1.8) - 459.67));
                break;
            case 6:
                Console.WriteLine("Converting to Celsius gives: " + (intTemp - 273.15));
                break;
        }
        Console.WriteLine("Ok bye bye now");

    }
}

