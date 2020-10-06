#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <cstdlib>

int main() {

	int numeroProcesos;
	std::cin >> numeroProcesos;
	int pid = 0;

	for (int i = 0; i < numeroProcesos; ++i)
	{

		if (pid == 0)
		{
			std::cout << "Soy " << getpid() << " Hijo de " << getppid() << " y soy de color " << (i % 2 == 0 ? "negro" : "rojo") << std::endl;
			pid = fork();

		} else {
			wait(NULL);

		}


	}
	return 0;
}

