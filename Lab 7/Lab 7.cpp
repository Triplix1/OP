// Lab 7.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <ctime>
#include <math.h>
using namespace std;


void input(int, double*);
void output(double*);
void find(int, double*);
int main()
{
	int x;
	cout << "Namber numbers afer point(from 0 till 3): ";
	cin >> x;
	double b[10];
	input(x, b);
	output(b);
	find(x, b);
	cout << "Result:" << endl;
	output(b);
}

void input(int x, double* arr)
{
	srand(time(NULL));
	for (int i = 0; i < 10; i++)
	{
		arr[i] = double((rand() % (20 * int(pow(10, x))) - int(pow(10, x + 1))) / double(pow(10, x)));
	}
}

void output(double* arr)
{
	for (int k = 0; k < 10; k++)
	{
		cout << k + 1 << " elemetn: " << arr[k] << endl;
	}
}

void find(int x, double* arr)
{
	double c;
	for (int f = 0; f < 10; f++) 
	{
		if (arr[f] < 0)
		{
			c = 0;
			for (int z = 0; z < x; z++)
			{
				c -= int(arr[f] * int(pow(10, x - z))) % 10;
			}
			arr[f] = c;
		}
	}
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
