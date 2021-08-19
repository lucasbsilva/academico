#include <stdio.h>

// Programa - Conversor de Moedas

int main()
{
    float valor, libra, marco, dolar;
    
    printf("Informe um valor em reais (R$): ");
    scanf("%f", &valor);
    
    libra = valor * 6.82;
    marco = valor * 0.31;
    dolar = valor * 5.32;
    
    printf("Confira o valor digitado em outras moedas: ");
    printf("\n Em Libra Esterlina o valor digitado em reais valeria R$ %.2f.", libra);
    printf("\n Em Marco Alemão o valor digitado em reais valeria R$ %.2f.", marco);
    printf("\n Em Dólar o valor digitado em reais valeria R$ %.2f.", dolar);

    return 0;
}
