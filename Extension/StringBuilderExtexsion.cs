using System.Text;


namespace OldPhonePad.Extension;

public static class StringBuilderExtexsion
{
    public static StringBuilder RemoveLast(this StringBuilder builder)
    {
        return builder.Remove(builder.Length - 1 , 1);
    }

    public static StringBuilder RemoveLast(this StringBuilder builder, int occerence)
    {
        if (occerence > builder.Length)
        {
            return builder.Remove(0, builder.Length);
        }

        return builder.Remove(builder.Length - occerence, occerence);
    }
}
