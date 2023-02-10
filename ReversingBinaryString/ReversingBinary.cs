namespace ReversingBinaryString;

public static class ReversingBinary
{
    public static int ReverseToBinaryString(this int num)
    {
        var binaryStr = num.NumberToBinary();
        var reversedBinaryStr = string.Join(string.Empty, binaryStr.Reverse());
        return reversedBinaryStr.BinaryToNumber();
    }

    private static string NumberToBinary(this int num)
    {
        string binary = string.Empty;

        while (num > 0)
        {
            binary += num % 2 == 0 ? "0" : "1";
            num = num / 2;
        }

        return string.Join(string.Empty, binary.Reverse());
    }

    private static int BinaryToNumber(this string binary)
    {
        var result = 0;
        var reversedBinary = string.Join(string.Empty, binary.Reverse());

        for (int i = 0; i < reversedBinary.Length; i++)
        {
            var currentNumber = int.Parse(reversedBinary[i].ToString());
            result += (int)(currentNumber * Math.Pow(2, i));
        }

        return result;
    }
}