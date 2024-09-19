using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        string pattern = @"(0[1-9]|1[0-2])([0-2][0-9]|3[01])\d{4}";
        
        MatchCollection matches = Regex.Matches(input, pattern);
        
        foreach (Match match in matches)
        {
            string date = match.Value;
            // Optional: Validate the date
            if (DateTime.TryParseExact(date, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime validDate))
            {
                Console.WriteLine($"Valid date found: {validDate.ToString("MM/dd/yyyy")}");
            }
        }
    }
}
