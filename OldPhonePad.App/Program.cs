#nullable enable

using OldPhonePad.Extension;
using OldPhonePad.Helper;
using System.Text;

namespace OldPhonePad;

public sealed class Program
{
    private static readonly string ValidInput = "1234567890#* ";

    /// <summary>
    /// Converts an input string representing old phone keypad presses into the corresponding text.
    /// '#' character for the end of input.
    /// '*' character removing the last character.
    /// '0' character for a space.
    /// </summary>
    /// <param name="input">A string representing the sequence of keypad presses.</param>
    /// <returns>The decoded text based on the input.</returns>
    public static string OldPhonePad(string input)
    {
        var output = new StringBuilder();
        while (!input.Equals('#') || !string.IsNullOrEmpty(input))
        {
            //find last index of occerecnce charactor;
            var lastOccerecnceCharIndex = input.Select((c, i) => new
            {
                Charactor = c,
                Index = i,
            }).FirstOrDefault(c => !c.Charactor.Equals(input[0]));

            if (lastOccerecnceCharIndex == null)
            {
                break;
            }

            if (input[0] == ' ')
            {
                input = input.Substring(lastOccerecnceCharIndex.Index);
                continue;
            }

            //Build output string
            if (input[0].Equals('*'))
            {
                output.RemoveLast(lastOccerecnceCharIndex.Index);
            }
            else if (input[0].Equals('0'))
            {
                output.Append(' ', lastOccerecnceCharIndex.Index);
            }

            var occerecnceChars = input.Substring(0, lastOccerecnceCharIndex.Index);
            var value = PadInputHelper.GetPadValueByOccerenceCharactors(occerecnceChars);
            if (value == '(')
            {
                value = PadInputHelper.GetOpenCloseBracket(output.ToString());
            }

            output.Append(value);
            input = input.Substring(lastOccerecnceCharIndex.Index);
        }

        return output.ToString();
    }

    public static void Main()
    {
        RunTestCase();
        while (true)
        {
            Console.Write("Input phone pad and end with '#' (or press 'ESC' to exit): ");
            var input = ReadInput();
            if (string.IsNullOrEmpty(input))
            {
                Environment.Exit(0);
            }

            var result = OldPhonePad(input);
            Console.WriteLine($"result: {result}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
    }

    private static string? ReadInput()
    {
        var input = new StringBuilder();
        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                return null;
            }

            if (key.KeyChar.Equals('#'))
            {
                input.Append(key.KeyChar);
                Console.WriteLine(key.KeyChar);
                return input.ToString();
            }

            if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input.RemoveLast();
                Console.Write("\b \b");
                continue;
            }

            if (!ValidInput.Contains(key.KeyChar))
            {
                continue;
            }

            input.Append(key.KeyChar);
            Console.Write(key.KeyChar);
        }
    }

    private static void RunTestCase()
    {
        Console.WriteLine("Start running default test case");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"OldPhonePad(“33#”) => output: {OldPhonePad("33#")}");
        Console.WriteLine($"OldPhonePad(“227*#”) => output: {OldPhonePad("227*#")}");
        Console.WriteLine($"OldPhonePad(“4433555 555666#”) => output: {OldPhonePad("4433555 555666#")}");
        Console.WriteLine($"OldPhonePad(“8 88777444666*664#”) => output: {OldPhonePad("8 88777444666*664#")}");
        Console.WriteLine($"OldPhonePad(“123**123#”) => output: {OldPhonePad("123**123#")}");
        Console.WriteLine($"OldPhonePad(“120000001155657777 23444**#”) => output: {OldPhonePad("120000001155657777 23444**#")}");
        Console.WriteLine($"OldPhonePad(“1122**************#”) => output: {OldPhonePad("1122**************#")}");
        Console.WriteLine($"OldPhonePad(“123**1#”) => output: {OldPhonePad("123**1#")}");
        Console.WriteLine($"OldPhonePad(“12300**1#”) => output: {OldPhonePad("12300**1#")}");
        Console.WriteLine($"OldPhonePad(“12300**1#”) => output: {OldPhonePad("111 11**1#")}");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
}