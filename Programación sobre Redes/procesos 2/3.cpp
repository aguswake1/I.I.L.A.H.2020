#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>


int main()
{
	std::cout << "Abraham" << std::endl;
	int pid = fork();

	if (pid == 0)
	{
		std::cout << "Homero" << std::endl;
		int pidBart = fork();
		
		if (pidBart == 0)
		{
			std::cout << "Bart" << std::endl;
			exit(0);
		} else {
			wait(NULL);  // clave
			int pidLisa = fork();

			if (pidLisa == 0)
			{
				std::cout << "Lisa" << std::endl;
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