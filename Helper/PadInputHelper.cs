#nullable enable

namespace OldPhonePad.Helper;

public static class PadInputHelper
{
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

    public static char GetPadValueByOccerenceCharactors(string occerenceChars)
    {
        if (occerenceChars.Length == 0 || !padInputKeyValue.TryGetValue(occerenceChars[0], out var group))
        {
            return '\0';
        }

        var valueIndex = (occerenceChars.Length - 1) % group.Length;
        return group[valueIndex];
    }
}
