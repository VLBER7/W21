int liczba = 12344154;
string liczbaDoZnaku = liczba.ToString();
char[] znaki = liczbaDoZnaku.ToArray();

int zera = 0;
int jedynki = 0;
int dwojki = 0;
int trojki = 0;
int czworki = 0;
int piatki = 0;
int szostki = 0;
int siodemki = 0;
int osemki = 0;
int dziewiatki = 0;

foreach (char c in znaki)
{
    if (c == '0')
    {
        zera++;
    }
    else if (c == '1')
    {
        jedynki++;
    }
    else if (c == '2')
    {
        dwojki++;
    }
    else if (c == '3')
    {
        trojki++;
    }
    else if (c == '4')
    {
        czworki++;
    }
    else if (c == '5')
    {
        piatki++;
    }
    else if (c == '6')
    {
        szostki++;
    }
    else if (c == '7')
    {
        siodemki++;
    }
    else if (c == '8')
    {
        osemki++;
    }
    else if (c == '9')
    {
        dziewiatki++;
    }
}
Console.WriteLine($"Twoja liczba to {liczba}, powtarzalość poszczególnych w niej cyfr to:");
Console.WriteLine($"0: -> {zera}");
Console.WriteLine($"1: -> {jedynki}");
Console.WriteLine($"2: -> {dwojki}");
Console.WriteLine($"3: -> {trojki}");
Console.WriteLine($"4: -> {czworki}");
Console.WriteLine($"5: -> {piatki}");
Console.WriteLine($"6: -> {szostki}");
Console.WriteLine($"7: -> {siodemki}");
Console.WriteLine($"8: -> {osemki}");
Console.WriteLine($"9: -> {dziewiatki}");