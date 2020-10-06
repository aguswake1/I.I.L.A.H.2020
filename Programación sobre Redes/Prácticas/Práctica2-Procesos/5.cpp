#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <cstdlib>
#include <string>
#include <vector>
#include <cstdio>
using namespace std;

vector<string> split(string comando, string delimitador){
    vector<string> argumentos;
    size_t actual = comando.find(delimitador);
    size_t anterior = 0;
    while (actual != string::npos)
    {
        string token = comando.substr(anterior, actual-anterior);
        argumentos.push_back(token);
        anterior = actual + 1;
        actual = comando.find(delimitador, anterior);  // Parámetro find(lo que tiene que buscar, desde donde)
    }
    string token = comando.substr(anterior, comando.size()-anterior);
    argumentos.push_back(token);
    return argumentos;


}

int main(){
    /*
    string s = "hola chao vaso nene flor";
    vector<string> arg = split(s, " ");
    for (size_t i = 0; i < arg.size(); i++)
    {
        cout << arg[i] << endl;
    }*/

    while(true){
        cout << "> ";
        int pid;

        // Parte 1: Procesamiento de datos.
        string comando;
        getline(cin, comando);  // Usamos getline para obtener toda la línea. cin lee hasta el primer espacio, salto de línea (\n) o fin de archivo que consigue.
        vector<string> arg = split(comando, " ");

        // Parte 2: Retrocompatibilidad con C.
        const char** argumentos = new const char*[arg.size()];
        // const char** argumentos = (const char**) malloc(sizeof(const char*) * arg.size());

        for(size_t i = 0; i < arg.size(); i++)
        {
            argumentos[i] = arg[i].c_str();
        }

        // Parte 3: Ejecutar.
        // execvp termina con la ejecución del programa que lo llamó.
        // Tenemos que crear un clon del proceso para que llame a execvp y no mate al proceso principal.

        pid = fork();

        if(pid == 0){ // hijo
            execvp (argumentos[0], (char* const*)argumentos);
            exit(0);
        }else{ // padre
            wait(NULL);
        }
    }
    return 0;
}

//cout << comando << endl;  substr + find
// int execvp(const char* comando, char* const argv[])
// ls -a -l
// execvp("ls", {"ls", "-a", "-l"})´
// strtok(char* inicio, char delimitador);