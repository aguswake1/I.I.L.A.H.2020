#include <unistd.h>
#include <string>
#include <iostream>
#include <thread>
#include <vector>
#include <atomic>

#define SIZE 100
using namespace std;

/* Ejercicio 2:
   Crear 2 threads de manera que cada uno de ellos setee una mitad de los valores de un arrelgo
   en 1 y el otro en 0.
   Para el tamaño del arreglo, pueden definir una constante SIZE a algún valor arbitrario

*/

void set_array(vector<int> &v, bool firstHalf)
{
   if (firstHalf)
   {
      for (size_t i = 0; i < SIZE / 2; i++)
      {
         v[i] = 0;
      }
   }
   else
   {
      for (size_t i = SIZE / 2; i < SIZE; i++)
      {
         v[i] = 1;
      }
   }
}

int main()
{
   vector<int> v(SIZE);
   thread t1 = thread(set_array, ref(v), true);
   thread t2 = thread(set_array, ref(v), false);
   t1.join();
   t2.join();

   for (size_t i = 0; i < SIZE; i++)
   {
      cout << v[i] << endl;
   }
}
