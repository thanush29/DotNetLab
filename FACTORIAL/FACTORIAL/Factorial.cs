using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace Factorial 
{ 
class Program 
{ 
static void Main(string[] args) 
{ 
long fact = 1; 
Console.Write("Enter the no to find factorial:"); 
int n = int.Parse(Console.ReadLine()); 
for (int i = 2; i<= n; i++) 
{ 
fact = fact * i; 
} 
Console.WriteLine("\n The factorial is:"); 
Console.WriteLine(n+"!="+fact); 
Console.ReadLine(); 
} 
} 
}