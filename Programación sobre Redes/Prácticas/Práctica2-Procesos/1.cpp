#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>

int main(){
    int x = 0;
    int pid = fork();
    if (pid == 0){
        x++;
        exit(0);
    } else if(pid > 0) {
        x++;
        wait(NULL);
        printf("%d", x);
        exit(0);
    }
}

/* El valor de x es 1. Es indistinto el orden de la ejecución de los procesos en este caso, porque
la x va a seguir valiendo lo mismo sea tanto el padre como el hijo.*/
