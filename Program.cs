
// Variables
double r, a;
const double PI = 3.1416;

//Entrada 
System.Console.Write("Valor del radio: ");
r = double.Parse(System.Console.ReadLine());

//Proceso
a =PI * Math.Pow(r, 2);

//Salida
System.Console.Write("El area es de : " + a);
System.Console.ReadKey();
