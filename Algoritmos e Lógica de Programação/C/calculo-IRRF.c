#include <stdio.h>

int main()
{   
    // Declaração de variáveis
    float sal, inss, depend, novosal, aliquota;
    char cpf[12];
    
    // Entrada de dados
    printf("Calculo de Imposto de Renda Retido na Fonte.\n\n");
    printf("Informe todos os digitos do seu CPF (somente números): ");
    scanf("%s", cpf);
    
    printf("\nInforme o seu salário bruto (separe as casas decimais com ponto):\nR$ ");
    scanf("%f", &sal);
    
    printf("\nInforme a quantidade de dependentes: ");
    scanf("%f", &depend);
    
    printf("\nConfira os dados informados:");
    printf("\nCPF: %s", cpf);
    printf("\nSalário bruto: R$ %.2f", sal);
    printf("\nNúmero de dependentes: %.0f", depend);
    
    // Verificação INSS
    if(sal <= 1045)
        inss = (sal * 7.5) / 100;
    else
        
    if(sal == 1045.01 || sal <= 2089.60)
        inss = (sal * 9) /100;
    else
            
    if(sal == 2089.61 || sal <= 3134.40)
        inss = (sal * 12) / 100;
    else
                
    if(sal == 3134.41 || sal <= 6101.06)
        inss = (sal * 14) / 100;
    
    // Cálculo pelo Nº de dependentes
    depend = depend * 189.59;
    
    novosal = sal - inss - depend;
    
    // Verificação IRRF
    
    if (novosal <= 1903.98)
        printf("\n\nIsento (você não precisa declarar o IRPF).");
    else
    
    if (novosal == 1903.99 || novosal <= 2826.65)
        {
        aliquota = (novosal * 7.5) / 100;
        aliquota = aliquota - 142.80;
        printf("\n\nValor destinado ao Imposto de Renda Retido na Fonte: R$ %.2f", aliquota);
        }
    else
            
    if (novosal == 2826.66 || novosal <= 3751.05)
        {
        aliquota = (novosal * 15) / 100;
        aliquota = aliquota - 354.80;
        printf("\n\nValor destinado ao Imposto de Renda Retido na Fonte: R$ %.2f", aliquota);
        }
    else
            
    if (novosal == 3751.06 || novosal <= 4664.68)
        {
        aliquota = (novosal * 22.5) / 100;
        aliquota = aliquota - 636.13;
        printf("\n\nValor destinado ao Imposto de Renda Retido na Fonte: R$ %.2f", aliquota);
        }
    else
                
    if (novosal >= 4664.68)
        {
        aliquota = (novosal * 27.5) / 100;
        aliquota = aliquota - 869.36;
        printf("\n\nValor destinado ao Imposto de Renda Retido na Fonte: R$ %.2f", aliquota);
        }

    return 0;
}