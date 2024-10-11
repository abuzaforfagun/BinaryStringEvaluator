namespace BinaryStringEvaluator;

public class BinaryStringEvaluator
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        var onesCount = 0;
        var zerosCount = 0;

        foreach (var ch in binaryString)
        {
            if (ch == '1')
                onesCount++;
            else if (ch == '0')
                zerosCount++;
            else
                throw new ArgumentException("Input string must contain only '0' or '1'.");

            if (zerosCount > onesCount)
                return false;
        }

        return onesCount == zerosCount;
    }
}
