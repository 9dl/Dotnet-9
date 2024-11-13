using static System.Console;

namespace Dotnet9;

public static class Dotnet9
{
    private static void Main()
    {
        byte[] bytes =
        [
            0b01001000, 
            0b01100101, 
            0b01101100, 
            0b01101100, 
            0b01101111, 
            0b00101100,
            0b00100000,
            0b01010111, 
            0b01101111, 
            0b01110010, 
            0b01101100, 
            0b01100100, 
            0b00100001
        ];
        
        var bytesToString = System.Text.Encoding.ASCII.GetString(bytes);
        WriteLine(bytesToString);
    }
}
