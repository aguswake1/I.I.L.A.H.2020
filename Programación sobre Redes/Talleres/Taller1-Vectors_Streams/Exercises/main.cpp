
#include "taller.h"
using namespace std;

int main()
{
    vector<int> vectorRey;
    vectorRey.push_back(5);
    vectorRey.push_back(7);
    vectorRey.push_back(3);
    vectorRey.push_back(2);
    vectorRey.push_back(1);
    cout << mayor(vectorRey) << endl; //Ejercicio 0
    for (int i = 0; i < reverso(vectorRey).size(); i++)
    {
        cout << reverso(vectorRey)[i] << ' ';         //Ejercicio 1
    }
    printf("\n");

    for (int i = 0; i < rotar(vectorRey, 2).size(); i++)
    {
        cout << rotar(vectorRey, 2)[i] << ' ';        //Ejercicio 2
    }
    printf("\n");


    for (int i = 0; i < sumarOne(vectorRey).size(); i++)
    {
        cout << sumarOne(vectorRey)[i] << ' ';      //Ejercicio 3
    }
    printf("\n");

    mostrarVector(vectorRey, cout);
    printf("\n");                                   //Ejercicio 5

    guardarVector(vectorRey, "ej6.txt");            //Ejercicio 6
    printf("\n");


    cout << estaOrdenado(vectorRey) << endl;
}
