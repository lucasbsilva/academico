import java.util.Scanner;
import java.text.DecimalFormat;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Cálculo da Quantidade de Azulejos por Parede\n");
		
		Scanner recebeDados = new Scanner(System.in);
		DecimalFormat formatacao = new DecimalFormat("#,###.0");
		
		System.out.print("Qual a largura, em cm, da parede que deseja revestir (Ex. 1m = 100cm)? ");
		float largParede = recebeDados.nextFloat();
		System.out.print("Qual a altura, em cm, da parede que deseja revestir (Ex. 1m = 100cm)?  ");
		float altParede = recebeDados.nextFloat();
		
		System.out.print("\nO azulejo com o qual revestira a parede informada é quadrado? Digite 1 para sim e 2 para não.\nSua resposta: ");
		int resposta = recebeDados.nextInt();
		
		float largAzulejo = 0;
		float altAzulejo = 0;
		float qtdeAzulejo = 0;
		
		if (resposta == 1){
		    System.out.print("\nInforme a largura, em cm, de qualquer um dos lados do seu azulejo (Ex. 0,3m = 30cm): ");
		    largAzulejo = recebeDados.nextFloat();
		    qtdeAzulejo = (largParede*altParede)/(largAzulejo*largAzulejo);
		} else {
		    System.out.print("\nQual a largura, em cm, do azulejo (Ex. 0,3m = 30cm)? ");
    		largAzulejo = recebeDados.nextFloat();
    		System.out.print("Qual a altura, em cm, do azulejo (Ex. 0,3m = 30cm)?  ");
    		altAzulejo = recebeDados.nextFloat();
    		qtdeAzulejo = (largParede*altParede)/(largAzulejo*altAzulejo);
		}
		
		System.out.println("\nPara revestir a parede informada, você precisara de " + formatacao.format(qtdeAzulejo) + " azulejos.");
	}
}
