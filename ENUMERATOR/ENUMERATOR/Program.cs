using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace enumerator 
{ 
class Area 
{ 
public enum Shape 
{ 
circle, 
square 
} 
public void areashape(int x, Shape shape) 
{ 
double area; 
switch (shape) 
{ 
case Shape.circle: 
area = Math.PI * x * x; 
Console.WriteLine("circle area=" + area); 
break; 
case Shape.square: 
area = x * x; 
Console.WriteLine("square area=" + area); 
break; 
} 
} 
} 
class enumtest 
{ 
static void Main(string[] args) 
{ 
Area area = new Area(); 
area.areashape(15, Area.Shape.circle); 
area.areashape(15, Area.Shape.square); 
area.areashape(15, (Area.Shape)1); 
area.areashape(15, (Area.Shape)10); 
Console.ReadLine(); 
} 
} 
}