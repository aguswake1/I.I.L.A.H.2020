#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
using namespace std;

// Propuesta original del enunciado: arbol binario (2 procesos x hijo) de altuna n
/*int main()
{
    int alturaArbol;
    cout << "Ingrese la altura del árbol binario: " << endl;
    //si alturaArbol = 2 | cantProcesos = 2³-1
    //si alturaArbol = 3 | cantProcesos = 2⁴-1
    cin >> alturaArbol;

    for (size_t i = 0; i < alturaArbol; i++)
    {
        int pid = fork();

        if (pid > 0)
        {
            pid = fork();

            if (pid > 0)
            {
                wait(NULL);
                wait(NULL);
                printf("PID %d | PPID %d\n", getpid(), getppid());
                exit(0);
            }
        }
    }
    printf("PID %d | PPID %d\n", getpid(), getppid());
    return 0;
}*/

// variante: arbol altura n que genere m cantidad de procesos
int main()
{
    int alturaArbol, cantProcesos;
    do
    {
        cout << "Ingrese la altura del árbol binario:\n";
        cin >> alturaArbol;
        cout << "Ingrese la cantidad de procesos que generaran los procesos del árbol:\n";
        cin >> cantProcesos;
    } while (alturaArbol < 1 && cantProcesos < 1);

    for (size_t i = 0; i < alturaArbol; i++)
    {
        int pid = 1;
        // for de creacion
        for (size_t j = 0; j < cantProcesos; j++)
        {
            if (pid > 0)
            {
                pid = fork();
            }
        }
        //for de espera
        if (pid > 0)
        {
            for (size_t j = 0; j < cantProcesos; j++)
            {

                wait(NULL);
            }
            printf("PID %d | PPID %d\n", getpid(), getppid());
            exit(0);
        }
    }
    printf("PID %d | PPID %d\n", getpid(), getppid());
    return 0;
}
