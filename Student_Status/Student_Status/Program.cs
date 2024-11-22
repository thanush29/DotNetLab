using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace studentlist 
{ 
struct student 
{ 
public string name; 
public int rollnumber; 
public string dept; 
public int mark; 
public int total, avg; 
} 
class Program 
{ 
static void Main(string[] args) 
{ 
student s; 
int total = 0; 
Console.Write("Enter the Name:"); 
s.name = Console.ReadLine(); 
Console.Write("Enter the Register Number:"); 
s.rollnumber = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the Dept.:"); 
s.dept = Console.ReadLine(); 
int[] mark = new int[5]; 
Console.WriteLine("Enter the 5 Subject Marks"); 
    for (int i = 0; i< 5; i++) 
{ 
mark[i] = Convert.ToInt32(Console.ReadLine()); 
total = total + mark[i]; 
} 
Console.WriteLine("Name:" + s.name); 
Console.WriteLine("Register Number:" + s.rollnumber); 
Console.WriteLine("Dept.:" + s.dept); 
Console.WriteLine("Total Marks:" + total); 
Console.WriteLine("Average:" + total / 5); 
Console.ReadLine(); 
} 
} 
}