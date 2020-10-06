#include <string>
#include <iostream>
#include <thread>
#include <vector>


using namespace std;

void primer_thread()
{
    cout << "Mi primer thread!" << endl;
    
    // Ojo con esto! Si hacemos exit, como con los procesos, estamos matando a todos
    // los threads dentro del proceso, incluído el thread principal

    //exit(0);
    return;
}


int main() 
{ 
   
    thread th = thread(primer_thread); 

    // Importante! Si no hacemos join para esperar al thread creado, habrá problemas
    th.join();

    cout << "Listo, a otra cosa" << endl;
} 
