#include "header.h"

int main(void)
{
    int                 socket_fd;
    int                 len;
    struct sockaddr_un  remote;
    char                buf[MENSAJE_MAXIMO];

    /* Crear un socket de domino UNIX (estableciendo la familia de direcciones) cuyo tipo de protocolo es SOCK_STREAM.
    SOCK_STREAM: Provides sequenced, reliable, two-way, connection-based byte streams.  An out-of-band data transmission mechanism may be supported
    El 0 indica cual protocolo espcifico se usa dentro de los de tipo SOCK_STREAM, en general siempre hay uno solo*/

    if ((socket_fd = socket(AF_UNIX, SOCK_STREAM, 0)) == -1) {
        perror("creando socket");
        exit(1);
    }

    /* Establecer la dirección a la cual conectarse. */
    remote.sun_family = AF_UNIX;
    strcpy(remote.sun_path, SOCK_PATH);
    len = strlen(remote.sun_path) + sizeof(remote.sun_family);

    /* Conectarse. */
    if (connect(socket_fd, (struct sockaddr *)&remote, len) == -1) {
        perror("conectandose");
        exit(1);
    }

    
    do{
    	printf("> ");
    	fgets(buf, MENSAJE_MAXIMO, stdin);
    	/*  Enviar el buffer utilizando el socket apuntado por socket_fd.*/
        if (send(socket_fd, buf, strlen(buf), 0) == -1) {
            perror("enviando");
            exit(1);
        }
    }while(!feof(stdin));

    /* Cerrar el socket. */
    close(socket_fd);

    return 0;
}
