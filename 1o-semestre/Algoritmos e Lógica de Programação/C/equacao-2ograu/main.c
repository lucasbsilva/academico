#include <stdio.h>
#include <math.h>

int main()
{
    float termo1, termo2, termo3, delta, x1, x2;
    
    printf("Informe o valor do primeiro termo da equação (A): ");
    scanf("%f", &termo1);
    
    printf("Informe o valor do segundo termo da equação (B): ");
    scanf("%f", &termo2);
    
    printf("Informe o valor do terceiro termo da equação (C): ");
    scanf("%f", &termo3);
    
    delta = pow(termo2, 2) - (4 * termo1 * termo3);
    
    if (delta < 0)
        printf("A equação não possuí raízes reais.");
    else
    {
        x1 = (- termo2 + sqrt(delta)) / (2 * termo1);
        x2 = (- termo2 - sqrt(delta)) / (2 * termo1);
        printf("As raízes são: %.2f e %.2f", x1, x2);
    }

    return 0;
}
