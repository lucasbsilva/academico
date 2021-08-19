#include <stdio.h>

int main()
{
    float num1, num2, media;
    
    printf("Digite um número qualquer: ");
    scanf("%f", &num1);
    
    printf("Digite outro número qualquer: ");
    scanf("%f", &num2);
    
    media = (num1+num2)/2;
    
    printf("A média dos números informados é: %.2f", media);
    
    return 0;
}
