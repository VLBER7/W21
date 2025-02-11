int number = 12344154;
    string numberToLetters = number.ToString();
        char[] letters = numberToLetters.ToArray();

int zero = 0;
int ones = 0;
int twos = 0;
int threes = 0;
int fours = 0;
int fives = 0;
int sixes = 0;
int sevens = 0;
int eights = 0;
int nines = 0;
foreach (char c in letters)
{
    if (c == '0')
{
     zero++;
}
    else if (c == '1')
{
     ones++;
}
    else if (c == '2')
{
     twos++;
}
    else if (c == '3')
{
     threes++;
}
    else if (c == '4')
{
     fours++;
}
    else if (c == '5')
{
     fives++;
}
    else if (c == '6')
{
     sixes++;
}
    else if (c == '7')
{
     sevens++;
}
    else if (c == '8')
{
     eights++;
}
    else if (c == '9')
{
     nines++;
}
}
Console.WriteLine($"Twoja liczba: {number}, powtarzalość poszczególnych w niej cyfr to:");
Console.WriteLine($"0: -> {zero}");
Console.WriteLine($"1: -> {ones}");
Console.WriteLine($"2: -> {twos}");
Console.WriteLine($"3: -> {threes}");
Console.WriteLine($"4: -> {fours}");
Console.WriteLine($"5: -> {fives}");
Console.WriteLine($"6: -> {sixes}");
Console.WriteLine($"7: -> {sevens}");
Console.WriteLine($"8: -> {eights}");
Console.WriteLine($"9: -> {nines}");