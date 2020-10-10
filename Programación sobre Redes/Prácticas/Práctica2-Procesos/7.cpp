#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
using namespace std;

int main()
{
    int alturaArbol;
    cout << "Ingrese la altura del árbol binario: " << endl;
    cin >> alturaArbol;

    for (size_t i = 0; i < alturaArbol; i++)
    {
        int pid = fork();
    }

    return 0;
}