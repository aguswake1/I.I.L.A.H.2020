#include "header.h"
#include <unistd.h>
#include <sys/types.h>
#include <stdio.h>
#include <wait.h>

#define MAX_MSG_LENGTH 1024
#define PORT 5432

void ejecutar_string(char *str)
{

    char buffer[MENSAJE_MAXIMO];
    strcpy(buffer, str);
    char *token; // punteros
    int num_palabras = 0;

    token = strtok(str, " \n");

    while (token != NULL)
    {
        num_palabras++;
        printf("%s\n", token);

        token = strtok(NULL, " \n");
    }

    printf("numero de palabras: %d\n", num_palabras);

    const char **argumentos = (const char **)malloc((num_palabras + 1) * sizeof(char *));

    token = strtok(buffer, " \n");
    int i = 0;
    while (token != NULL)
    {
        argumentos[i++] = token;

        token = strtok(NULL, " \n");
    }

    argumentos[i] = NULL;

    int pid = fork();

    if (pid == 0)
    {
        execvp(argumentos[0], (char *const *)argumentos);
        exit(0);
    }
    else
    {
        wait(NULL);
    }
}

int leer_de_socket(char str[], int s)
{
    int n;
    n = recv(s, str, MENSAJE_MAXIMO, 0);
    if (n == 0)
        return -1;
    if (n < 0)
    {
        perror("recibiendo");
        exit(1);
    }

    str[n] = '\0';
    printf("recibi: %s", str);
    ejecutar_string(str);
    return 0;
}

int main(void)
{
    int s, s1, t, len;
    struct sockaddr_in local;
    struct sockaddr_in remote;
    char str[MENSAJE_MAXIMO];
    int n;

    /* Crear un socket de tipo PF_INET  con TCP (SOCK_STREAM). */
    if ((s = socket(PF_INET, SOCK_STREAM, 0)) == -1)
    {
        perror("creando socket");
        exit(1);
    }

    /* Definimos el puerto donde escuchar y el dominio, ahora AF_INET en lugar de UNIX_DOMAIN */

    local.sin_family = AF_INET;
    local.sin_port = htons(PORT);

    /* INADDR_ANY es una constante que permitira asignarle, como direccion, "multiples" direcciones.
       Esto se hace para que al hacer el bin, el servidor escuche, por ejemplo, en loopback (ej:127.0.0.1) y ethernet(ej 192.168.1.30) */
    local.sin_addr.s_addr = INADDR_ANY;

    /* Establecer la dirección a la cual conectarse para escuchar (especificada en el struct local) */
    if (bind(s, (struct sockaddr *)&local, sizeof(local)) < 0)
    {
        perror("haciendo bind");
        exit(1);
    }

    /* Escuchar en el socket y permitir 5 conexiones en espera. */
    if (listen(s, 5) == -1)
    {
        perror("escuchando");
        exit(1);
    }

    /* Aceptar una conexión entrante. */ //t = sizeof(local);

    /* Los parametros que son NULL pueden cambiarse para obtener informacion de la direccion del cliente que se conectó */
    if ((s1 = accept(s, NULL, NULL)) == -1)
    {
        perror("aceptando la conexión entrante");
        exit(1);
    }

    /* Mostrar en pantalla todo lo que recibimos. */
    while (1)
    {

        if (leer_de_socket(str, s1) == -1)
            break;
    }

    /* Cerrar la conexión entrante. */
    close(s1);

    /* Cerrar la conexión que escucha. */
    close(s);

    return 0;
}
