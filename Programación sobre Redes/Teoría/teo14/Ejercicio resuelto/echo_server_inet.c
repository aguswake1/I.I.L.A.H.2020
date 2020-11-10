#include "header.h"
#include "ctype.h"

using namespace std;

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
    for (int i = 0; i < n - 1; i++)
    {
        str[i] = toupper(str[i]);
    }
    send(s, str, strlen(str), 0);
    return 0;
}

void connection_handler(int socket_desc)
{

    while (1)
        if (leer_de_socket(socket_desc) == -1)
            break;
}

int main(void)
{
    int s, s1, len;
    struct sockaddr_un local, remote;
    thread threads[MAX_CLIENTS];
    /* Crear un socket de tipo UNIX con TCP (SOCK_STREAM). */
    if ((s = socket(AF_UNIX, SOCK_STREAM, 0)) == -1)
    {
        perror("creando socket");
        exit(1);
    }

    /* Establecer la dirección a la cual conectarse para escuchar. */
    local.sun_family = AF_UNIX;
    strcpy(local.sun_path, SOCK_PATH);
    unlink(local.sun_path);
    len = strlen(local.sun_path) + sizeof(local.sun_family);

    if (bind(s, (struct sockaddr *)&local, len) == -1)
    {
        perror("haciendo bind");
        exit(1);
    }

    /* Escuchar en el socket y permitir MAX_CLIENTS conexiones en espera. */
    if (listen(s, MAX_CLIENTS) == -1)
    {
        perror("escuchando");
        exit(1);
    }

    int t = sizeof(remote);
    int i = 0;
    while ((accept(s, (struct sockaddr *)&remote, (socklen_t *)&t)))
    {
        if (s1 == -1)
        {
            perror("aceptando la conexión entrante");
            exit(1);
        }
        threads[i++] = thread(connection_handler, s1);
        if (i == MAX_CLIENTS)
        {
            for (int j = 0; j < MAX_CLIENTS; j++)
            {
                threads[j].join();
            }
            i = 0;
        }
    }

    /* Cerrar las conexiones entrantes. */
    close(s1);

    /* Cerrar la conexión que escucha. */
    close(s);

    return 0;
}
