using System;
namespace FirstProject
{
 class Program 
 {
  static void Main(string[] args)
  {
   int num = new Random().Next(10);
   Console.WriteLine("Guess my number (0-10)");
   int responseInt = -1;
   bool response;
   while (responseInt != num) {
    response = Int32.TryParse(Console.ReadLine(), out responseInt);
    if (responseInt == num && response == true) {
     Console.WriteLine("You got it!");
    } else if (responseInt <= num) {
     Console.WriteLine("Your guess was less than my number.");
    } else if (responseInt >= num) {
     Console.WriteLine("Your guess was greater than my number.");
    } else {
     Console.WriteLine("Nice try bucko.");
    break;
    }
   }
  }
 }
}