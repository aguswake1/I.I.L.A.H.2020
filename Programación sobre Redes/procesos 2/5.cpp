#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <cstdlib>
#include <string>
#include <vector>

std::vector<std::string> split(std::string comando, std::string delimitador){
    std::vector<std::string> argumentos;
    size_t actual = comando.find(delimitador);
    size_t anterior = 0;
    while (actual != std::string::npos)
    {
        std::string token = comando.substr(anterior, actual-anterior);
        argumentos.push_back(token);
        anterior = actual + 1;
        actual = comando.find(delimitador, anterior);  // Parámetro find(lo que tiene que buscar, desde donde)
    }
    std::string token = comando.substr(anterior, comando.size()-anterior);
    argumentos.push_back(token);
    return argumentos;


}

int main(){
    /*
    std::string s = "hola chao vaso nene flor";
    std::vector<std::string> arg = split(s, " ");
    for (size_t i = 0; i < arg.size(); i++)
    {
        std::cout << arg[i] << std::endl;
    }*/

    while(true){
        std::cout << "> ";
        int pid;
        std::string comando;
        std::getline(std::cin, comando);
        std::vector<std::string> arg = split(comando, " ");



        pid = fork();

        if(pid == 0){
            execvp(argumentos[0], (char* const*)argumentos);
        }else{
            wait(NULL);
            std::cout << "bien" << std::endl;
        }
    }
    return 0;
}

//std::cout << comando << std::endl;  substr + find