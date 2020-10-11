#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>

/*Es una secuencia de outputs posible porque luego del ciclo for, en
el condicional no hay ninguna opción por si se ejecuta el proceso
padre, generando que posiblemente algún hijo se ejecute después que el padre.*/
int main()
{
	int pid, status;
	for (int i = 0; i < 5; i++)
	{
		pid = fork();
		if (pid == 0)
		{
			printf("Proceso %d\n", i);
			exit(0);
		}
		else
		{
			wait(NULL); //Solución
		}
	}

	if (pid > 0)
	{
		wait(&status);
		printf("Terminaron todos\n");
		exit(0);
	}
}