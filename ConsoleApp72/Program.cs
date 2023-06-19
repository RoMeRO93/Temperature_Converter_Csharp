using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("=====================");

        bool convertAgain = true;

        while (convertAgain)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Celsius to Kelvin");
            Console.WriteLine("3. Celsius to Rankine");
            Console.WriteLine("4. Celsius to Newton");
            Console.WriteLine("5. Fahrenheit to Celsius");
            Console.WriteLine("6. Fahrenheit to Kelvin");
            Console.WriteLine("7. Fahrenheit to Rankine");
            Console.WriteLine("8. Fahrenheit to Newton");
            Console.WriteLine("9. Kelvin to Celsius");
            Console.WriteLine("10. Kelvin to Fahrenheit");
            Console.WriteLine("11. Kelvin to Rankine");
            Console.WriteLine("12. Kelvin to Newton");
            Console.WriteLine("13. Rankine to Celsius");
            Console.WriteLine("14. Rankine to Fahrenheit");
            Console.WriteLine("15. Rankine to Kelvin");
            Console.WriteLine("16. Rankine to Newton");
            Console.WriteLine("17. Newton to Celsius");
            Console.WriteLine("18. Newton to Fahrenheit");
            Console.WriteLine("19. Newton to Kelvin");
            Console.WriteLine("20. Newton to Rankine");
            Console.WriteLine("21. Quit");

            int option;
            while (true)
            {
                Console.Write("Enter your option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out option) && option >= 1 && option <= 21)
                    break;

                Console.WriteLine("Invalid option. Please enter a number between 1 and 21.");
            }

            if (option == 21)
            {
                Console.WriteLine("\nThank you for using the Temperature Converter!");
                break;
            }

            double temperature;
            string unitFrom, unitTo;

            Console.Write("Enter the temperature: ");
            string temperatureInput = Console.ReadLine();
            if (double.TryParse(temperatureInput, out temperature))
            {
                switch (option)
                {
                    case 1:
                        unitFrom = "Celsius";
                        unitTo = "Fahrenheit";
                        temperature = CelsiusToFahrenheit(temperature);
                        break;
                    case 2:
                        unitFrom = "Celsius";
                        unitTo = "Kelvin";
                        temperature = CelsiusToKelvin(temperature);
                        break;
                    case 3:
                        unitFrom = "Celsius";
                        unitTo = "Rankine";
                        temperature = CelsiusToRankine(temperature);
                        break;
                    case 4:
                        unitFrom = "Celsius";
                        unitTo = "Newton";
                        temperature = CelsiusToNewton(temperature);
                        break;
                    case 5:
                        unitFrom = "Fahrenheit";
                        unitTo = "Celsius";
                        temperature = FahrenheitToCelsius(temperature);
                        break;
                    case 6:
                        unitFrom = "Fahrenheit";
                        unitTo = "Kelvin";
                        temperature = FahrenheitToKelvin(temperature);
                        break;
                    case 7:
                        unitFrom = "Fahrenheit";
                        unitTo = "Rankine";
                        temperature = FahrenheitToRankine(temperature);
                        break;
                    case 8:
                        unitFrom = "Fahrenheit";
                        unitTo = "Newton";
                        temperature = FahrenheitToNewton(temperature);
                        break;
                    case 9:
                        unitFrom = "Kelvin";
                        unitTo = "Celsius";
                        temperature = KelvinToCelsius(temperature);
                        break;
                    case 10:
                        unitFrom = "Kelvin";
                        unitTo = "Fahrenheit";
                        temperature = KelvinToFahrenheit(temperature);
                        break;
                    case 11:
                        unitFrom = "Kelvin";
                        unitTo = "Rankine";
                        temperature = KelvinToRankine(temperature);
                        break;
                    case 12:
                        unitFrom = "Kelvin";
                        unitTo = "Newton";
                        temperature = KelvinToNewton(temperature);
                        break;
                    case 13:
                        unitFrom = "Rankine";
                        unitTo = "Celsius";
                        temperature = RankineToCelsius(temperature);
                        break;
                    case 14:
                        unitFrom = "Rankine";
                        unitTo = "Fahrenheit";
                        temperature = RankineToFahrenheit(temperature);
                        break;
                    case 15:
                        unitFrom = "Rankine";
                        unitTo = "Kelvin";
                        temperature = RankineToKelvin(temperature);
                        break;
                    case 16:
                        unitFrom = "Rankine";
                        unitTo = "Newton";
                        temperature = RankineToNewton(temperature);
                        break;
                    case 17:
                        unitFrom = "Newton";
                        unitTo = "Celsius";
                        temperature = NewtonToCelsius(temperature);
                        break;
                    case 18:
                        unitFrom = "Newton";
                        unitTo = "Fahrenheit";
                        temperature = NewtonToFahrenheit(temperature);
                        break;
                    case 19:
                        unitFrom = "Newton";
                        unitTo = "Kelvin";
                        temperature = NewtonToKelvin(temperature);
                        break;
                    case 20:
                        unitFrom = "Newton";
                        unitTo = "Rankine";
                        temperature = NewtonToRankine(temperature);
                        break;
                    default:
                        unitFrom = "";
                        unitTo = "";
                        break;
                }

                Console.WriteLine($"\n{temperatureInput} {unitFrom} is equal to {temperature} {unitTo}.");
            }
            else
            {
                Console.WriteLine("Invalid temperature. Please enter a valid number.");
            }

            Console.Write("\nConvert another temperature? (Y/N): ");
            string convertAgainInput = Console.ReadLine();
            convertAgain = (convertAgainInput.ToUpper() == "Y");
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double CelsiusToRankine(double celsius)
    {
        return (celsius + 273.15) * 9 / 5;
    }

    static double CelsiusToNewton(double celsius)
    {
        return celsius * 33 / 100;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit + 459.67) * 5 / 9;
    }

    static double FahrenheitToRankine(double fahrenheit)
    {
        return fahrenheit + 459.67;
    }

    static double FahrenheitToNewton(double fahrenheit)
    {
        return (fahrenheit - 32) * 11 / 60;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static double KelvinToFahrenheit(double kelvin)
    {
        return kelvin * 9 / 5 - 459.67;
    }

    static double KelvinToRankine(double kelvin)
    {
        return kelvin * 9 / 5;
    }

    static double KelvinToNewton(double kelvin)
    {
        return (kelvin - 273.15) * 33 / 100;
    }

    static double RankineToCelsius(double rankine)
    {
        return (rankine - 491.67) * 5 / 9;
    }

    static double RankineToFahrenheit(double rankine)
    {
        return rankine - 459.67;
    }

    static double RankineToKelvin(double rankine)
    {
        return rankine * 5 / 9;
    }

    static double RankineToNewton(double rankine)
    {
        return (rankine - 491.67) * 11 / 60;
    }

    static double NewtonToCelsius(double newton)
    {
        return newton * 100 / 33;
    }

    static double NewtonToFahrenheit(double newton)
    {
        return newton * 60 / 11 + 32;
    }

    static double NewtonToKelvin(double newton)
    {
        return newton * 100 / 33 + 273.15;
    }

    static double NewtonToRankine(double newton)
    {
        return newton * 60 / 11 + 491.67;
    }
}
