using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hours:");
    var hours = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Miles:");
    var miles = Convert.ToDouble(Console.ReadLine());
    var math = 200 + 150 * hours  + 2 * miles;
    Console.WriteLine ("${0}", math);
  }
}