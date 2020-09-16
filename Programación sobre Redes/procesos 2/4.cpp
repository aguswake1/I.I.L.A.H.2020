#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>

int main(){
	int pid, status;
	for(int i = 0; i<5; i++){
		pid = fork();
		if(pid == 0){
			printf("Proceso %d\n", i);
			exit(0);
		} else {
			wait(NULL);
		}
	}

	if(pid > 0){
		wait(&status);
		printf("Terminaron todos\n");
		exit(0);
	}
}
