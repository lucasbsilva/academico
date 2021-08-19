import java.util.Scanner;
import java.lang.Math;
import java.text.DecimalFormat;

public class Main
{
	public static void main(String[] args) {
	    
	    Scanner recebeDados = new Scanner(System.in);
	    DecimalFormat formatacao = new DecimalFormat("#,###.00");
	    
	    System.out.print("Cálculo de Área e Perímetro da Circunferência\n\nDigite o raio da sua circunferência: ");
	    
	    double raio = recebeDados.nextDouble();
	    
	    // cálculos
	    double area = Math.PI * Math.pow(raio, 2);
	    double perimetro = 2 * Math.PI * raio;
	    
	    System.out.println("\nA circunferência de raio " + raio + " tem área de " + formatacao.format(area) + " e perímetro de " + formatacao.format(perimetro) + ".");
	}
}
