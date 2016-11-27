#include <stdio.h>
#include <stdlib.h>
 
// структура для хранения числа и количества его четных положительных делителей
typedef struct {
    unsigned value; // число
    unsigned countDivisor; // количество делителей
} Pair;
 
// функция возвращает количество делителей числа value,
// само value также рассматривается в качестве делителя 

unsigned CountDiv( const int value );


Pair MaxCountDiv( const int value );
 
int main( void ) {
 
    int n;
    int n1 = 100;
    int n2 = 1000000;
 
    }
   
    Pair number = MaxCountDiv( n );
    // выводим результаты
    printf( "Число = %u\n", n, number.value );
    printf( "Количество положительных делителей = %u\n", number.countDivisor );
 
    return EXIT_SUCCESS;
}
 
unsigned CountDiv( const int value ) {
    int i; // счетчик цикла
 
   
    unsigned counter = 1; // число всегда является делителем самого себя
    
    for ( i = n1; i <= 1000000; i += 1 ) 
        if ( value % i == 0 ) 
            ++counter; 
 
    return counter; 
}
 
Pair MaxCountDiv( const int value ) {
    
    Pair sought = { 0, 0 }; // хранение числа и количества его делителей
 
    for ( i = 100; i <= 1000000; ++i ) { 
        unsigned count = CountDiv( i ); 
        if ( count > sought.countDivisor )  
            sought.value = i; 
            sought.countDivisor = count; 
        }
    }
 
    return sought; // возвращаем результат
}