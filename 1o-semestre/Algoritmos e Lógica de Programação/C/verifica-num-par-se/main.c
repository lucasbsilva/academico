#include <stdio.h>

// Programa - Verrificação de número par

int main()
{
    // Declaração de variáveis
    int num;
    
    
    printf("Digite um número e aperte ENTER: ");
    scanf("%d", &num);
    
    // Estrutura condicional (SE)
    if(num % 2 == 0)
        printf("O número digitado é par.");
    else
        printf("O número digitado é ímpar.");

    return 0;
}

