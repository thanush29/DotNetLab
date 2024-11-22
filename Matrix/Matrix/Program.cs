using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace matrix 
{ 
class Program 
{ 
static void Main(string[] args) 
{ 
int i, j; 
int[,] a = new int[2, 2]; 
int[,] b = new int[2, 2]; 
int[,] c = new int[2, 2]; 
Console.WriteLine("Enter the first matrix:"); 
for (i = 0; i< 2; i++) 
{ 
for (j = 0; j < 2; j++) 
{ 
a[i, j] = Convert.ToInt32(Console.ReadLine()); 
} 
} 
Console.WriteLine("Enter the Second matrix:"); 
for (i = 0; i< 2; i++) 
{ 
for (j = 0; j < 2; j++) 
{
    b[i, j] = Convert.ToInt32(Console.ReadLine()); 
} 
} 
Console.WriteLine("Resultant of two matrix is:"); 
for (i = 0; i< 2; i++) 
{ 
for (j = 0; j < 2; j++) 
{ 
c[i, j] = a[i, j] + b[i, j]; 
Console.WriteLine(+c[i, j]); 
} 
} 
Console.ReadLine(); 
} 
} 
}