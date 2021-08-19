import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		
		Scanner entraDados = new Scanner(System.in);
		
		System.out.println("Cálculo de Área e Perímetro de um retângulo.\n");
		
		System.out.print("Informe a largura do seu retângulo: ");
		double larg = entraDados.nextDouble();
		
		System.out.print("Informe a altura do seu retângulo: ");
		double alt = entraDados.nextDouble();
		
		double area = larg * alt;
		double perimetro = (larg*2)+(alt*2);
		
		System.out.println("\nA área do seu retângulo é " + area + ", e o perímetro " + perimetro + ".");
	}
}

