#include <assert.h>
#include <stdio.h>

int main ()
{
  int a = 0;
  int b, n = 1;
  int i = 1;
    while (i <= 1000)
	{          
        printf(n, " ");
        n=a+b;
        a=b;
        b=n;		
    }

  return 0;
}