using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace OldPhonePad.Tests;

public class OldPhonePadTest
{
    [Fact]
    public void Test_Default_Input()
    {
        Assert.Equal("E", Program.OldPhonePad("33#"));
    }

    [Fact]
    public void Test_Single_Letter()
    {
        // test button 1
        Assert.Equal("&", Program.OldPhonePad("1#"));
        Assert.Equal("'", Program.OldPhonePad("11#"));
        Assert.Equal("(", Program.OldPhonePad("111#"));

        // test button 2
        Assert.Equal("A", Program.OldPhonePad("2#"));
        Assert.Equal("B", Program.OldPhonePad("22#"));
        Assert.Equal("C", Program.OldPhonePad("222#"));

        // test button 3
        Assert.Equal("D", Program.OldPhonePad("3#"));
        Assert.Equal("E", Program.OldPhonePad("33#"));
        Assert.Equal("F", Program.OldPhonePad("333#"));

        // test button 4
        Assert.Equal("G", Program.OldPhonePad("4#"));
        Assert.Equal("H", Program.OldPhonePad("44#"));
        Assert.Equal("I", Program.OldPhonePad("444#"));

        // test button 5
        Assert.Equal("J", Program.OldPhonePad("5#"));
        Assert.Equal("K", Program.OldPhonePad("55#"));
        Assert.Equal("L", Program.OldPhonePad("555#"));

        // test button 6
        Assert.Equal("M", Program.OldPhonePad("6#"));
        Assert.Equal("N", Program.OldPhonePad("66#"));
        Assert.Equal("O", Program.OldPhonePad("666#"));

        // test button 7
        Assert.Equal("P", Program.OldPhonePad("7#"));
        Assert.Equal("Q", Program.OldPhonePad("77#"));
        Assert.Equal("R", Program.OldPhonePad("777#"));
        Assert.Equal("S", Program.OldPhonePad("7777#"));

        // test button 8
        Assert.Equal("T", Program.OldPhonePad("8#"));
        Assert.Equal("U", Program.OldPhonePad("88#"));
        Assert.Equal("V", Program.OldPhonePad("888#"));

        // test button 9
        Assert.Equal("W", Program.OldPhonePad("9#"));
        Assert.Equal("X", Program.OldPhonePad("99#"));
        Assert.Equal("Y", Program.OldPhonePad("999#"));
        Assert.Equal("Z", Program.OldPhonePad("9999#"));
    }

    [Fact]
    public void Test_Single_Letter_Wrap_Around()
    {
        // test button 1
        Assert.Equal("&", Program.OldPhonePad("1111#"));
        Assert.Equal("'", Program.OldPhonePad("11111#"));
        Assert.Equal("(", Program.OldPhonePad("111111#"));

        // test button 2
        Assert.Equal("A", Program.OldPhonePad("2222#"));
        Assert.Equal("B", Program.OldPhonePad("22222#"));
        Assert.Equal("C", Program.OldPhonePad("222222#"));

        // test button 3
        Assert.Equal("D", Program.OldPhonePad("3333#"));
        Assert.Equal("E", Program.OldPhonePad("33333#"));
        Assert.Equal("F", Program.OldPhonePad("333333#"));

        // test button 4
        Assert.Equal("G", Program.OldPhonePad("4444#"));
        Assert.Equal("H", Program.OldPhonePad("44444#"));
        Assert.Equal("I", Program.OldPhonePad("444444#"));

        // test button 5
        Assert.Equal("J", Program.OldPhonePad("5555#"));
        Assert.Equal("K", Program.OldPhonePad("55555#"));
        Assert.Equal("L", Program.OldPhonePad("555555#"));

        // test button 6
        Assert.Equal("M", Program.OldPhonePad("6666#"));
        Assert.Equal("N", Program.OldPhonePad("66666#"));
        Assert.Equal("O", Program.OldPhonePad("666666#"));

        // test button 7
        Assert.Equal("P", Program.OldPhonePad("77777#"));
        Assert.Equal("Q", Program.OldPhonePad("777777#"));
        Assert.Equal("R", Program.OldPhonePad("7777777#"));
        Assert.Equal("S", Program.OldPhonePad("77777777#"));

        // test button 8
        Assert.Equal("T", Program.OldPhonePad("8888#"));
        Assert.Equal("U", Program.OldPhonePad("88888#"));
        Assert.Equal("V", Program.OldPhonePad("888888#"));

        // test button 9
        Assert.Equal("W", Program.OldPhonePad("99999#"));
        Assert.Equal("X", Program.OldPhonePad("999999#"));
        Assert.Equal("Y", Program.OldPhonePad("9999999#"));
        Assert.Equal("Z", Program.OldPhonePad("99999999#"));
    }

    [Fact]
    public void Test_World_HELLO()
    {
        Assert.Equal("HELLO", Program.OldPhonePad("4433555 555666#"));
    }

    [Fact]
    public void Test_World_HELLO_WORLD()
    {
        Assert.Equal("HELLO WORLD", Program.OldPhonePad("4433555 555666096667775553#"));
    }

    [Fact]
    public void Test_World_HELLO_WORLD_By_Remove_LD()
    {
        Assert.Equal("HELLO WOR", Program.OldPhonePad("4433555 555666096667775553**#"));
    }

    [Fact]
    public void Test_World_HELLO_With_Over_Removed_Should_Get_Empty()
    {
        Assert.Equal("", Program.OldPhonePad("4433555 555666**************************************#"));
    }

    [Fact]
    public void Test_World_HELLO_WORLD_With_Tripple_Blank_Space()
    {
        Assert.Equal("HELLO   WORLD", Program.OldPhonePad("4433555 55566600096667775553#"));
    }


    [Fact]
    public void Test_World_HELLO_WORLD_With_Bracket()
    {
        Assert.Equal("(HELLO WORLD)", Program.OldPhonePad("111 4433555 555666096667775553 111#"));
    }

    [Fact]
    public void Test_Wrong_Charactor_Input_Should_Empty()
    {
        Assert.Equal("", Program.OldPhonePad("asdwasdSdasdwdasd#"));
    }
}