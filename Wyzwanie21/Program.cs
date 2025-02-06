string gender = "K";
string name = "Ewa";
int age = 19;

if (gender == "K" && age < 30)
    Console.WriteLine("Kobieta ponizej 30 lat");
else if (name == "Ewa" && age == 30)
    Console.WriteLine("Ewa, lat 30");
else if (gender != "K" && age < 18)
    Console.WriteLine("Niepelnoletni mezczyzna");

