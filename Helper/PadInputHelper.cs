#nullable enable

namespace OldPhonePad.Helper;

public static class PadInputHelper
{
    //dicionary of keypad and value
    //using dict to optimize finding value with O(1)
    private static readonly IReadOnlyDictionary<char, string> padInputKeyValue = new Dictionary<char, string>
    {
        { '1', "&'("},
        { '2', "ABC"},
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" }
    };

    //find decoded charactor from occerence charactor
    public static char GetPadValueByOccerenceCharactors(string occerenceChars)
    {
        //error handle for wrong input the return empty charactor.
        if (occerenceChars.Length == 0 || !padInputKeyValue.TryGetValue(occerenceChars[0], out var group))
        {
            return '\0';
        }

        //find index of decoded value following repeat times using % to prevent index out of range.
        var valueIndex = (occerenceChars.Length - 1) % group.Length;
        return group[valueIndex];
    }
}
