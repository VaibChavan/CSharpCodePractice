
public class Reverse
{
    public string ReverseStr(string input)
    {
        char[] chars = input.ToCharArray();
        string res = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            res += chars[i];
        }
        return res;
    }
}

class program
{
    static void Main(string[] args)
    {
        string str = "CSharp";
        Reverse reverse = new Reverse();
        string Result = reverse.ReverseStr(str);

        Console.WriteLine(Result);
        Console.ReadKey();
    }
}



