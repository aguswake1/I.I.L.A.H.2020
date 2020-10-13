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

   int index = 0;

   while (index < 20)
   {
      threads.push_back(thread(task1, &index));
      threads[index].join();
      index++;
   }
}
