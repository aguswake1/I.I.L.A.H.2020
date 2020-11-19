#include "header.h"
using namespace std;

/* Dado un socket, un nickname y el estado de login, registra un nuevo cliente con el nickname dado si el
mismo no se encuentra en uso.
En caso contrario, envia un mensaje indicando la falla. Además, actualiza
   la variable log con el nuevo estado de login del cliente. */
Client addClient(int s, const string &nickname)
{

    /* COMPLETAR */
}

/* Dado un cliente, lo elimina del sistema y cierra su socket adecuadamanete(ver shutdown()) */
void deleteClient(Client &c)
{

    /* COMPLETAR */
}

/* Dado un nick, devuelve un puntero al cliente encontrado con dicho nickname. En caso de no existir,
   el puntero es NULL */
Client *getClient(const string &nick)
{
    /* COMPLETAR */
}

/* Dado un cliente y un mensaje, envía dicho mensaje a traves del socket asociado al cliente */
void send(Client *c, const string &msg)
{
    /* COMPLETAR */
}

/* Funcion que ejecutan los threads */
void connection_handler(int socket_desc)
{

    /* Pedir login */

    /* Main loop */
    while (1)
    {

        /* leer socket, salir si hubo error*/
        /* COMPLETAR */

        /* Parsear el buffer recibido*/
        /* COMPLETAR */

        /* Detectar el tipo de mensaje (crudo(solo texto) o comando interno(/..),
           y ejecutar la funcion correspondiente segun el caso */
        /* COMPLETAR */
    }

    //return NULL;
}

int connection_setup()
{

    int listening_socket;

    /* Crear un socket de dominio INET con TCP (SOCK_STREAM).  */

    listening_socket = socket(AF_INET, SOCK_STREAM, 0);

    if (listening_socket == -1)
    {
        perror("No se pudo crear el socket :(");
        exit(1);
    }

    /* Establecer la dirección a la cual conectarse para escuchar. */
    struct sockaddr_in server;

    server.sin_family = AF_INET;
    server.sin_port = htons(5007);

    // Se utiliza INADDR_ANY para que el ejecutable no restrinja la dirección por la que se puede llamar al servidor.
    server.sin_addr.s_addr = INADDR_ANY;

    if (bind(listening_socket, (struct sockaddr *)&server, sizeof(server)) < 0)
    {
        perror("No se pudo hacer el bind correctamente :(");
        exit(1);
    }

    /* Escuchar en el socket y permitir 5 conexiones en espera. */

    if (listen(listening_socket, 5) < 0)
    {
        perror("No se pudo escuchar en el socket :(");
        exit(1);
    }

    printf("Server is on! \n");
    return listening_socket;
}

int main(void)
{

    // Abrimos un socket para escuchar conexiones entrantes
    int server_socket = connection_setup();

    int new_socket;
    int auxiliar = sizeof(struct sockaddr_in);
    struct sockaddr_in client;

    while (1)
    {

        // Main loop del servidor
        // Aqui se aceptan conexiones y handlea a cada cliente a partir de un thread
        printf("Esperando conexion...\n");
        new_socket = accept(server_socket, (struct sockaddr *)&client, (socklen_t *)&auxiliar);
    }

    /* Cerramos las conexiones pendientes. */
    /* COMPLETAR */

    /* Cerramos la conexión que escucha. */
    close(server_socket);

    return 0;
}
