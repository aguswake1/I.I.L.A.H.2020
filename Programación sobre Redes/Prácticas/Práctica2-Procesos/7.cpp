#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
using namespace std;

int main()
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

            if (pid == 0)
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
}