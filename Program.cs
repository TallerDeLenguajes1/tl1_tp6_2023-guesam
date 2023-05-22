// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); */

int a, c, e;
double d = 0;
string b;
Console.WriteLine("Ingrese un numero: ");
bool control = int.TryParse(Console.ReadLine(), out a);
if(control){
    if(a > 0){
        if(a < 10){
            Console.WriteLine(a);
        } else {
            b = Convert.ToString(a);
            c = b.Length;
            while(a >= 10){
                e = a % 10;
                d += e * Math.Pow(10, c-1);
                a /= 10;
                c--;
            }
            d += a;
            Console.WriteLine(d);
        }
    } else {
        Console.WriteLine("El numero es negativo");
    }
} else {
    Console.WriteLine("Ingrese un numero.");
}