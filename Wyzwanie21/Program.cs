using Wyzwanie21;

Employee user1 = new Employee("Alek", "Cezarski", 21);
Employee user2 = new Employee("Barek", "Barski", 22);
Employee user3 = new Employee("Czarek", "Alski", 23);

user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(5);
user1.AddScore(6);
var result1 = user1.Result;
user2.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(6);
user2.AddScore(7);
var result2 = user2.Result;
user3.AddScore(4);
user3.AddScore(5);
user3.AddScore(6);
user3.AddScore(7);
user3.AddScore(8);
var result3 = user3.Result;

var users = new[] {user1, user2, user3};
var results = new[] {result1, result2, result3};
int win = Array.IndexOf(results, results.Max());
Console.WriteLine("Najwyzszy wynik to: " + results[win] + ", Imie: " + users[win].Name + ", Nazwisko: " + users[win].Surname + ", Wiek: " + users[win].Age + ".");
