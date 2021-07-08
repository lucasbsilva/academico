#include <stdio.h>

// Programa - Soma de dois números inteiros

int main()
{
    // Declaração de variáveis
    int A, B, SOMA;
    
    
    printf("Digite um número: ");
    scanf("%d", &A);
    
    printf("\n Digite um segundo número: ");
    scanf("%d", &B);
    
    SOMA = A + B;

    printf("A soma dos números digitados é: %d",SOMA);

    return 0;
}
