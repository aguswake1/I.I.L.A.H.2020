#include "header.h"

int leer_de_socket(int s);

int main(void)
{
    int socket_fd;
    int len;
    struct sockaddr_un remote;
    char buf[MENSAJE_MAXIMO];

    /* Crear un socket de tipo UNIX con SOCK_STREAM */
    if ((socket_fd = socket(AF_UNIX, SOCK_STREAM, 0)) == -1)
    {
        perror("creando socket");
        exit(1);
    }

    /* Establecer la dirección a la cual conectarse. */
    remote.sun_family = AF_UNIX;
    strcpy(remote.sun_path, SOCK_PATH);
    len = strlen(remote.sun_path) + sizeof(remote.sun_family);

    /* Conectarse. */
    if (connect(socket_fd, (struct sockaddr *)&remote, len) == -1)
    {
        perror("conectandose");
        exit(1);
    }

    do
    {
        printf("> ");
        fgets(buf, MENSAJE_MAXIMO, stdin);
        /*  Enviar el buffer utilizando el socket apuntado por socket_fd.*/
        if (send(socket_fd, buf, strlen(buf), 0) == -1)
        {
            perror("enviando");
            exit(1);
        }
        leer_de_socket(socket_fd);
    } while (!feof(stdin));

    /* Cerrar el socket. */
    close(socket_fd);

    return 0;
}

int leer_de_socket(int s)
{
    int n;
    char str[MENSAJE_MAXIMO];
    n = recv(s, str, MENSAJE_MAXIMO, 0);
    if (n == 0)
        return -1;
    if (n < 0)
    {
        perror("recibiendo");
        return 0;
    }
    str[n] = '\0'; /* Agregar caracter de fin de cadena a lo recibido. */
    printf("%s", str);
    return 0;
}
