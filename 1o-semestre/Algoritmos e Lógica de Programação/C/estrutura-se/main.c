#include <stdio.h>

// Programa - Soma de dois números inteiros com SE

int main()
{
    // Declaração de variáveis
    float A, B, SOMA;
    
    
    printf("Digite um número: ");
    scanf("%f", &A);
    
    printf("Digite um segundo número: ");
    scanf("%f", &B);
    
    SOMA = A + B;

    printf("A soma dos números digitados é: %.2f",SOMA);
    
    // Estrutura condicional (SE)
    if(SOMA >= 1000)
        printf(" (Tá rico!)");
    else
        printf(" (Tá pobre!)");

    return 0;
}


