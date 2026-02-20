//prueba de variables en C#
string nombre_1 = "informaticonfig";
int edad_1= 20;
bool activo_1 = false;
DateTime fecha_1 = DateTime.Now;
float precio_1 = 1.500f;
decimal descuento_1 = 10.50m;
double descuento_2 = 10.50;

Console.WriteLine(nombre_1);
Console.WriteLine(edad_1);
edad_1 = 50;
Console.WriteLine(edad_1);
Console.WriteLine(descuento_1);
Console.WriteLine(activo_1);
Console.WriteLine(fecha_1);
Console.WriteLine(precio_1);
Console.WriteLine(descuento_2);


//uso de la concatenación en C#

string nombre = "Ana";
int edad_2 = 30;

Console.WriteLine("nombre de usuario: " + nombre + "\n" +
                   "Edad: " + edad_2);

Console.WriteLine($"Nombre de usuario: {nombre}, edad en diez años: {edad_2 +10}");


//prueba de constantes

var numero = 10.20;
Console.WriteLine(numero);
numero = 3000;
Console.WriteLine(numero);

const int numero_2 = 150;
Console.WriteLine("valor de constante: " + numero_2);

const double PI = 3.1416;
const string mensaje = "¡Bienvenidos!";

Console.WriteLine(PI);
Console.WriteLine(mensaje);

//CASTINGS
//Casting implícito

int valor = 200;
double total = valor;

Console.WriteLine("Implícito: " + total);

//Casting explícito
double precio = 500.23;
int descuento = (int)precio;

Console.WriteLine("Explícito: " + descuento);

char letra = 'A';
int codigoAsci = letra;
Console.WriteLine(codigoAsci);

string palabra = "123456";
int numero3 = Convert.ToInt32(palabra);
Console.WriteLine(numero3);

string textoDecimal = "150.60";
double valor2 = double.Parse(textoDecimal);
Console.WriteLine(valor2);

//Operadores Aritméticos
int valor_1 = 90, valor_2 = 70, valor_3 = 10;

//Operador de Suma
int total_suma = valor_1 + valor_2;
Console.WriteLine("Total suma: " + total_suma);

//resta
int diferencia = valor_1 - valor_2;
Console.WriteLine("Total diferencia: " + diferencia);

//multiplicación
int producto = valor_2 * valor_3;
Console.WriteLine("Total del producto: " + producto);

//divison
int resultadoDivision = valor_1 / valor_3;
Console.WriteLine("Total de la división: " + resultadoDivision);

//residuo
var modulo = valor_2 % valor_3;
Console.WriteLine("residuo: " + modulo);  


Console.ReadKey();