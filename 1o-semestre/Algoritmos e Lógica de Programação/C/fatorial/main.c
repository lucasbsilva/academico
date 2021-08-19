#include <stdio.h>
#include <math.h>

int main()
{
    int num, fat, i, j, termos;
    
    fat = 1;
    
    printf ("Digite um número: ");
    scanf ("%d", &num);
    
    for (i = 1; i <= num; i++)
        fat = fat * i;
    
    printf ("O fatorial do número digitado é: %d", fat);
    return 0;
}
