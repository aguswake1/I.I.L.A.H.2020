#include <iostream>
#include <cstdlib>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>


int main()
{
	const char* comando = "ls";
	const char* argumentos[4] = {"ls","-l", "-a", (char*)NULL};

	int pid = fork();

	if(pid == 0)
	{
		execvp(comando, (char* const*)argumentos);
	}
	else
	{
		wait(NULL);
	}


	/*
		Sugerencias:

			1) std::getline.

					std::string command;

					std::getline(std::cin, command);

			2) std::istringstream

					std::istringstream ss(command);

					do
					{
						std::string palabra;
						ss >> palabra;
	
					}while(ss)
	1*/


}






/*int main(int argc, char const *argv[])
{
	std::cout << argc << std::endl;

	for(int i = 0; i < argc; i++)
	{
		std::cout << argv[i] << std::endl;
	}

	return 0;
}*/