/*

        Problem:
        t and z are strings consist of lowercase English letters.

        Find all substrings for t, and return the maximum value of [ len(substring) x [how many times the substring occurs in z] ]

        Example:
        t = acldm1labcdhsnd
        z = shabcdacasklksjabcdfueuabcdfhsndsabcdmdabcdfa

        Solution:
        abcd is a substring of t, and it occurs 5 times in Z, abcd.Length x 5 = 20 is the solution

        */


string FindOccurance(string substring, string mainString)
{

    string longestSubstring = "";
    int maxLength = 0;
    int maxCount = 0;

    for (int i = 0; i < substring.Length; i++)
    {
        for (int j = i + 1; j <= substring.Length; j++)
        {
            string sbstring = substring.Substring(i, j - i);
            int count = CountOccurrences(mainString, sbstring);

            if (count > 0 && sbstring.Length > maxLength)
            {
                maxLength = sbstring.Length;
                longestSubstring = sbstring;
                maxCount = count;
            }
        }
    }

    return (longestSubstring.Length*maxCount).ToString();
}

int CountOccurrences(string text, string pattern)
{
    int count = 0;
    int i = 0;
    while ((i = text.IndexOf(pattern, i)) != -1)
    {
        i += pattern.Length;
        count++;
    }
    return count;
}

var t = "acldm1labcdhsnd";
var z = "shabcdacasklksjabcdfueuabcdfhsndsabcdmdabcdfa";

Console.WriteLine(FindOccurance(t, z));
