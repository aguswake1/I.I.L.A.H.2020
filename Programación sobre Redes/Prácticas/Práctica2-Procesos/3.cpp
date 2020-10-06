#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
using namespace std;

int main()
{
	cout << "Abraham" << endl;
	int pid = fork();

	if (pid == 0)
	{
		cout << "Homero" << endl;
		int pidBart = fork();

		if (pidBart == 0)
		{
			cout << "Bart" << endl;
			exit(0);
		} else {
			wait(NULL);  // Le decimos a Homero que espere a que finalice Bart para crear a Lisa.
			int pidLisa = fork();

			if (pidLisa == 0)
			{
				cout << "Lisa" << endl;
				exit(0);
			} else {
				wait(NULL);
			}
		}
		exit(0);
	} else {
		wait(NULL);
		exit(0);
	}
	return 0;
}
/* b-c-d.
El orden de salida es siempre la misma, el programa cuenta con la implementación del wait(NULL) para que
el proceso padre espere a que finalicen los hijos antes de ejecutarse. Si esto no fuera así, se podrían
generar procesos zombies.*/
