Compare("rwgjnreg", "wgkrng");
Compare("hello", "hello");
Compare("Hello", "hello");

Analyze("falkqnwef12324$$$");

void Compare(string a, string b)
{
    Console.WriteLine(a==b?"true":"false");
}

void Analyze(string a)
{
    int numbers = 0, specialCharacters = 0, alp = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] >= '0' && a[i] <= '9')
        {
            numbers++;
        }
        else if(a[i] >= 'a' && a[i] <= 'z')
        {
            alp++;
        }
        else
        {
            specialCharacters++;
        }
    }
    Console.WriteLine(numbers + " " + alp + " " + specialCharacters);
}

