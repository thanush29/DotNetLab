using System; 
namespace @struct 
{ 
class Program 
{ 
public struct employee 
{ 
int id; 
double salary; 
public employee(int id, double salary) 
{ 
this.id = id; 
this.salary = salary; 
} 
public employee(int id, int salary) 
{ 
this.id = id; 
this.salary = 3400.00; 
} 
public employee(employee x) 
{ 
this.id = x.id; 
this.salary = x.salary; 
} 
public void DisplayValues() 
{ 
Console.WriteLine("Structure"); 
Console.WriteLine("ID: " + this.id.ToString()); 
Console.WriteLine("Salary : " + this.salary.ToString()); 
} 
} 
static void Main(string[] args) 
{ 
employee emp = new employee(12,4560.00); 
emp.DisplayValues(); 
Console.ReadLine(); 
} 
} 
} 
