
#include <string>
#include <iostream>
#include <thread>
#include <vector>
#include <atomic>
using namespace std;

/* Ejercicio 1: 
   Crear 20 threads de manera que impriman todos los numeros del 0 al 19.
   Notar que cada thread debe imprimir solo un numero y debe tomar como parametro un puntero a un entero.
	
*/

void task1(int *c)
{
   cout << (*c) << endl;
}


int main() 
{ 
   
    vector<thread> threads;

    int contador = 0;
    while(contador < 20)
  	{
    	threads.push_back(thread(task1, &contador)); 
    	contador++;
  	}
  
    
    for(int i = 0; i<20;i++)
    	threads[i].join();

  
    cout << "chau" << endl;
} 
