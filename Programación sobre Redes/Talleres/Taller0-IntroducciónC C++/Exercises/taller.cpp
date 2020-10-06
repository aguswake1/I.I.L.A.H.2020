
#include <iostream>
#include <math.h>
#include <stdio.h>
#include <cmath>
#include "taller.h"
#include <algorithm>


using namespace std;
/* IMPORTANTE: <math.h> y <cmath> se incluyen
 * solo para que utilicen abs() y pow(),
 * si las neceistaran. */


// Ejercicio 0
// Dados enteros a y b, decide si 'a' divide a 'b'.
bool divide(int a, int b)
{
    if (b % a == 0)
        return true;
    else
        return false;
}

// Ejercicio 1
// Dados dos enteros a y b, devuelve el mayor.
int mayor(int a, int b)
{
    
    if (a > b)
        return a;
    else 
        return b;


}

// Ejercicio 2
// Dado un n, devuelve el factorial de n.
// unsigned int son los enteros positivos
unsigned int factorialPorCopia(int n)
{
unsigned int numFactorial = 1;
unsigned int i;
    for (i = 1; n >= i; i++)
{
        numFactorial = numFactorial * i;
}
        return numFactorial;
}

// Ejercicio 3
// Dado un n por teclado, imprimir el factorial de n por pantalla.
// Hint: Usar la función anterior
void factorialPorTeclado()
{
    unsigned int num;
    cin >> num;
   cout << factorialPorCopia(num) << endl;
}

//Ejercicio 4
// Dado un n por teclado, devuele true si y solo sí n es primo
bool esPrimo(int n)
{
int cantDivisores = 0;
//cin >> n;
for (int i = 1; i <= n; i++)
{
    if(n % i == 0)
    {
        cantDivisores++;
    }
}
if (cantDivisores == 2)
    return true;
else
    return false;

}

// Ejercicio 5
// Dado un n, devolver los primos gemelos menores o iguales a n.
// Dos numeros son primos gemelos si son primos y están a distancia 2.
// Q y P son primos gemelos si P=Q+2, por ejemlo 3 y 5, 5 y 7, 11 y 13...

bool primoGemelo(int n)
{  
unsigned int i, cantDivisor = 0;
unsigned int cantDivisorp1 = 0;
unsigned int cantDivisorp2 = 0;

    for (i = 1; i <= n; i++)
    {
        if (n % i == 0)
            cantDivisor++;                
    }    
    if (cantDivisor == 2)
    {
        unsigned int primogemeloide1 = n + 2;
        unsigned int primogemeloide2 = n - 2;
        for (i = 1; i <= primogemeloide1; i++)
        {
            
            if (n % i == 0)
                cantDivisorp1++;                
        }    
        for (i = 1; i <= primogemeloide2; i++)
        {
            
            if (n % i == 0)
                cantDivisorp2++;                
        }
        if (cantDivisorp1 == 2)    
            return true;
        else if (cantDivisorp2 == 2)
            return true;
        else
        {
            return false;
        }
               
    }
    else
    {
        return false;
    }
        
}


// Ejercicio 6
// Dado un numero capturado por teclado, decidir si es un palindromo.
// Por ejemplo: la entrada "hola mundo", deberia dar por resultado:
// "Numero: NO, Palindromo: NO". Mientras que "severlasalreves" deberia dar 
// "Numero: NO, Palindromo: SI"
// Hint: Ver las funciones at del tipo string y isdigit.

void esCapicua(string s)
{
    string doou = s;    
    reverse(s.begin(), s.end());
    if (doou == s)
        cout << "Es un palindromo papi" << endl;
    else
        cout << "No es un palindromo papi" << endl;   
    
    

}

// Ejercicio 7
// Dado un n, voy a escribir la secuencia de numeros de 0 a n
// Por ejemplo, n=4, da 0,1,2,3,4

void numerosHasta(int n)
{

    for (int i = 0;n >= i; i++) 
    {
        cout << i << " ";
    }
    
}

// Ejercicio 8
// Dado un n, escribir por pantalla una escalera desde 0 hasta n.
// Ejemplo: n=3, deberia mostrar:
// 0
// 0 1
// 0 1 2
// 0 1 2 3
// Hint: Usar la función anterior

void escaleraSimple(int n)
{
    for ( int i = 0; i <= n; i++)  
    {
        numerosHasta(i);
        printf ("\n");                //por cada vuelta del for, en la funcion numerosHasta se reinicia el valor de i.
    }
    

}



// Ejercicio 9
// Dado un 'n', dice si es numero perfecto o no
// Los numeros perfectos son enteros tales que su valor
// es igual a la suma de sus divisores
// Por ejemplo, 6 = 3+2+1... 28=1+2+4+7+14, etc...

bool esPerfecto(int n)
{
    int esNumeroPerfecto = 0;
    
    for (int i = 1; i < n; i++)
    {  
        if (n % i == 0)
            esNumeroPerfecto = esNumeroPerfecto + i;       
    } 
  
    if (n == esNumeroPerfecto)
        return true;
    else
        return false;    

}

// Ejercicio 10 (opcional)
// Dado un n capturado por teclado, imprimir el triangulo de pascal de grado n
// Por ejemplo, para n=5, deberia dar
// 1
// 1 1
// 1 2 1
// 1 3 3 1
// 1 4 6 4 1
void pascal()
{

}


// Ejercicio 11 (opcional)
// Dado un k positivo, devolver el k-esimo numero de la susesion de fibonacci.
long fibonacci(int k)
{
    return 1400;
}

// Ejercicio 12 (opcional)
// Dado un n PAR capturado por teclado, intenta ver si la Conjetura de Golbach es valida para ese n.
// Golbach dijo que todo entero n PAR estrictamente mayor a dos es expresable como
// la suma de dos numeros primos(se puede repetir el primo).
// Por ejemplo, 10=3+7, 1984=107+1877, etc...

void golbach()
{


}
