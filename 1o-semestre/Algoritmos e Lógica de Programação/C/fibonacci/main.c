#include <stdio.h>

int main()
{
    int num, a, b, serie, i;
    
    printf("Série de Fibonacci: Informe quantos números da série você quer visualizar: ");
    scanf("%d", &num);
    
    a = 0;
    b = 1;
    
    if (num <= 0)
        printf("Informe um número inteiro positivo maior que zero.");
    
    else
        if (num == 1)
            printf("%d.", a);
        
        else
            if (num == 2)
            printf("%d, %d.", a, b);
            
            else
            printf("%d, %d, ", a, b);
            
            for (i = 3; i <= num; i++)
            {
                serie = a + b;
                printf("%d", serie);
                
                if (i == num)
                    printf(". ");
                else
                    printf(", ");
                
                a = b;
                b = serie;
            }
    
    return 0;
}



