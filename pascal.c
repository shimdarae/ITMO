#include <stdlib.h>
#include <conio.h>
#include <string.h>

 	
long factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
        x *= i;
    return x;
}

int main(int argc, char const *argv[])
{
int i, n, c;
n = 10;
for (i = 0; i < n; i++)
        {
        for (c = 0; c <= (n - i); c++)
            printf(" ");
            for (c = 0; c <= i; c++)
                printf("%ld ", factorial(i) / (factorial(c)*factorial(i - c))); 
            printf("\n");
        }	
_getch();
}