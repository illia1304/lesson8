using System.Text;

Compare("rwgjnreg", "wgkrng");
Compare("hello", "hello");
Compare("Hello", "hello");

Analyze("falkqnwef12324$$$");

Sort("vcxa");

Duplicate("abcdabff");

void Compare(string a, string b)
{
    Console.WriteLine(a==b?"true":"false");
}

void Analyze(string a)
{
    int numbers = 0, specialCharacters = 0, alp = 0;
    foreach(char c in a)
    {
        numbers+=char.IsDigit(c) ? 1: 0;
        alp += char.IsLetter(c) ? 1: 0;
        specialCharacters += char.IsSeparator(c) ? 1: 0;
    }
    Console.WriteLine(numbers + " " + alp + " " + specialCharacters);
}

void Sort(string a)
{
    char[] chars = a.ToCharArray();
    Array.Sort(chars);

    for(int i = 0; i < chars.Length; i++)
    {
        Console.WriteLine(chars[i]);
    }
}

void Duplicate(string a)
{
    a = a.ToLower();
    StringBuilder duplicate = new StringBuilder();

    for(int i = 0; i < a.Length; i++)
    {
        for(int j = i+1; j < a.Length; j++)
        {
            if(a[i] == a[j])
            {
                duplicate.Append(a[j]);
            }
        }
    }
    Console.WriteLine(duplicate.ToString());
}
