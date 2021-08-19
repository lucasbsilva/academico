#include <stdio.h>

int main()
{
    int tab, i;
    
    printf("Tabuada - Digite o número da tabuada desejada e pressione ENTER: ");
    scanf("%d", &tab);
    
    for(i = 1; i <= 10; i++)
        printf("%d x %d = %d \n", tab, i, tab*i);

    return 0;
}