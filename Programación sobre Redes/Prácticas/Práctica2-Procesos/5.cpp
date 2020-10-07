#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <cstdlib>
#include <string>
#include <vector>
#include <cstdio>
using namespace std;

vector<string> split(string comando, string delimitador)
{
    vector<string> argumentos;
    size_t actual = comando.find(delimitador); // Definimos la variable actual como el lugar del delimitador
    size_t anterior = 0;                       // Definimos la variable anterior como el lugar donde empieza el comando

    while (actual != string::npos)
    {
        string token = comando.substr(anterior, actual - anterior); // extraemos el argumento actual
        argumentos.push_back(token);                                // Guardamos el argumento en el vector
        anterior = actual + 1;                                      // Actualizamos el valor de anterior para que este una posición a la derecha del antiguo valor de actual
        actual = comando.find(delimitador, anterior);               // Parámetro find(lo que tiene que buscar, desde donde)
        // Sale del ciclo cuando no encuentra más delimitadores
    }

    string token = comando.substr(anterior, comando.size() - anterior); // Encuentra el último argumento, el cúal no tiene un delimitador
    argumentos.push_back(token);
    return argumentos;
}

int main()
{

    while (true)
    {
        cout << "> ";
        int pid;

        // Parte 1: Procesamiento de datos.
        string comando;
        getline(cin, comando);                    // Usamos getline para obtener toda la línea. cin lee hasta el primer espacio, salto de línea (\n) o fin de archivo que consigue.
        vector<string> arg = split(comando, " "); // Se almacena en un vector de strings los comandos con sus parámetros por separado.

        // Parte 2: Retrocompatibilidad con C.
        const char **argumentos = new const char *[arg.size()]; // Reservamos espacio dinámicamente con el tamaño de arg
        // const char** argumentos = (const char**) malloc(sizeof(const char*) * arg.size());

        for (size_t i = 0; i < arg.size(); i++)
        {
            argumentos[i] = arg[i].c_str(); // Le pasamos los elementos de arg a argumentos pero conteniendolos como strings de C
        }

        // Parte 3: Ejecutar.
        // execvp termina con la ejecución del programa que lo llamó.
        // Tenemos que crear un clon del proceso para que llame a execvp y no mate al proceso principal.

        pid = fork();

        if (pid == 0)
        {
            execvp(argumentos[0], (char *const *)argumentos);
            exit(0);
        }
        else
        {
            wait(NULL);
        }
    }
    return 0;
}

// int execvp(const char* comando, char* const argv[])
