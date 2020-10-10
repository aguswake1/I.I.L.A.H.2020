#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <cstdlib>
using namespace std;

int main()
{
	int cantidadProcesos;
	cout << "Ingrese la cantidad de procesos que desee: " << endl;
	cin >> cantidadProcesos; // Capturamos entrada del usuario.
	int pid = 0;

	for (size_t i = 0; i < cantidadProcesos; i++) // Ciclo que clona procesos menos del último.
	{
		if (pid == 0)
		{
			// Hacemos que diga quien es, de quien es hijo y su color.
			cout << "Soy " << getpid() << ", mi viejo es " << getppid() << " y soy de color " << (i % 2 == 0 ? "Negro" : "Rojo") << endl;
			pid = fork();
		}
		else
		{
			wait(NULL);
		}
	}
	return 0;
}