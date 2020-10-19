#include <iostream>
#include <thread>
using namespace std;

void tarea1(int *punt){
	for (int i = 0; i < 2; ++i)
	{
		*punt += 2;
	}
}

void tarea2(int *punt){
	for (int i = 0; i < 2; ++i)
	{
		*punt -= 1;
	}
}

int main()
{
	int x = 0;
	thread t1 = thread(tarea1, &x);
	thread t2 = thread(tarea2, &x);
	t1.join();
	t2.join();
	cout << x << endl;
	return 0;
}
