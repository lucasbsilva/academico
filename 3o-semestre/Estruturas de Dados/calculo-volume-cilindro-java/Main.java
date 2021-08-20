import java.util.Scanner;
import java.lang.Math;
import java.text.DecimalFormat;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Cálculo do Volume de um Cilindro\n");
		
		Scanner enterData = new Scanner(System.in);
		DecimalFormat formatNumber = new DecimalFormat("#,###.00");
		
		System.out.print("Informe o valor do raio da base do seu cilindro: ");
		float raio = enterData.nextFloat();
		
		System.out.print("Informe o valor da altura do seu cilindro: ");
		float altura = enterData.nextFloat();
		
		double volume = altura * Math.PI * Math.pow(raio, 2);
		
		System.out.print("\nO volume do cilindro especificado é: " + formatNumber.format(volume) + ".");
	}
}
