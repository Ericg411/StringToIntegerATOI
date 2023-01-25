using System.Numerics;

namespace StringToIntegerATOI;
public class StringToInteger
{
    public int MyAtoi(string s)
    {
        List<char> charHolder = new List<char>();
        s = s.Trim();

        if (s == "")
        {
            return 0;
        }

        if (s[0] == '-' || s[0] == '+')
        {
            charHolder.Add(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (!int.TryParse(s[i].ToString(), out int a))
                {
                    break;
                }
                charHolder.Add(s[i]);
            }
            bool parsable = BigInteger.TryParse(new string(charHolder.ToArray()), out BigInteger bigIntParse);
            if (bigIntParse >= Int32.MaxValue)
            {
                return Int32.MaxValue;
            }
            else if (bigIntParse <= Int32.MinValue)
            {
                return Int32.MinValue;
            }
            int parsedS = (int)bigIntParse;
            return parsedS;
        }
        else
        {
            var counter = 0;
            foreach (char c in s)
            {
                if (!int.TryParse(c.ToString(), out int a))
                {
                    if (counter == 0)
                    {
                        return 0;
                    }
                    break;
                }
                charHolder.Add(c);
                counter++;
            }
            bool parsable = BigInteger.TryParse(new string(charHolder.ToArray()), out BigInteger bigIntParse);

            if (bigIntParse >= Int32.MaxValue)
            {
                return Int32.MaxValue;
            }
            else if (bigIntParse <= Int32.MinValue)
            {
                return Int32.MinValue;
            }
            int parsedS = (int)bigIntParse;
            return parsedS;
        }
    }

}
