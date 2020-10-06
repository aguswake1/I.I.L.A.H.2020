#include <string>
#include <stdio.h>
#include <cstdio>
#include <iostream>
#include "taller.h"


using namespace std;

int main()
{
    cout << divide(2,4) << endl; 
    cout << mayor(5, 5) << endl;
    cout << factorialPorCopia(4) << endl;
    factorialPorTeclado();
    cout << esPrimo(8) << endl;
    cout << primoGemelo(8) << endl;
    esCapicua("ana");
    numerosHasta(8);
    printf ("\n");
    escaleraSimple(3);
    
    printf ("\n");
    cout << esPerfecto(6) << endl;
}
