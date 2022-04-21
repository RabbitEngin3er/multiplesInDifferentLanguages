#include<iostream>
using namespace std;
#define SIZEX 4
#define SIZEY 10

void calcolaTabellina(int numero);

int main()
{
    int numero;
    cout << "Insert number to calculate its multiples ";
    cin >> numero;
    calcolaTabellina(numero);
}

void calcolaTabellina(int numero)
{
    int multiples[SIZEX][SIZEY];
    int a = 1;
    int i;
    int j;
    for (i = 0; i < SIZEX; i++)
    {
        for (j = 0; j < SIZEY; j++)
        {
            multiples[i][j] = a*numero;
            a+=1;
        }
    }

    for(i=0; i<SIZEX; i++)
    {
        for(j=0; j<SIZEY; j++)
        {
            cout << "\t" << multiples[i][j];
        }
        cout << "\n";
    }
}