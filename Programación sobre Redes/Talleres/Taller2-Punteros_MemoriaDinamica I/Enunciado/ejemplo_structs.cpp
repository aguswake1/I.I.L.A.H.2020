#include <string>
#include <iostream>

using namespace std;

//Consigna:

/* 1. Crear una función Champion* create_champion_op(string name) que crea un champion con el nombre pasado por
   parametro e inicializa todos sus stats en 100. Luego, devuelve un puntero a ese objeto 

   2. Crear una funcion void show_stats(Champion* c) que imprima todos los stats de un champion

   3. Desde main, crear un champion op y mostrar sus stats.

   4. Modificar alguno de estos valores y volver a mostrar los stats para verificar el cambio.
 
 */

struct Champion{

	string name;
	int hp;
	int attack_speed;
	int strength;

	Champion() : name("default"), hp(20), attack_speed(10), strength(3){}
	Champion(string s, int hp, int atk_spd, int sth) :  name(s), hp(hp), attack_speed(atk_spd), strength(sth){}
	
	void show_name()
	{
		cout<< name << endl;
	}
};

// Champion c se pasa por copia

void show_name(Champion c)
{
	cout<< c.name << endl;
}

void change_name(Champion* c_ptr)
{
	//(*c_ptr).name = "teemo";
	c_ptr->name = "teemo";
}
int main()
{
	// Creamos un champion por defecto
	Champion c;
	c.show_name();

	// Cambiamos su nombre
	c.name = "ashe";
	c.show_name();

	// Creamos un champion nuevo con el constructor que toma parámetros iniciales
	Champion veigar = Champion("veigar",30,10,20);
	show_name(veigar);

	
	// Creamos un puntero al champion veigar y lo modificamos indirectamente
	Champion* veigar_nerfeado;
	veigar_nerfeado = &veigar;
	veigar_nerfeado->strength = 2;

	// Veamos que el objeto original, veigar, ahora también tiene 2 de strength.
	cout << veigar.strength << endl;



}