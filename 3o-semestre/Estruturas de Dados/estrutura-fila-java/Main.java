public class Main
{
	public static void main(String[] args) {
		Fila f1 = new Fila(5);
		
		f1.adiciona(1);
		f1.adiciona(2);
		f1.adiciona(3);
		f1.adiciona(4);
		f1.adiciona(5);
		f1.adiciona(10);
		f1.imprime();
		
		System.out.println("\n\nFila cheia: " + f1.cheia());
		System.out.println("Fila vazia: " + f1.vazia() + "\n");
		
		f1.remove();
		f1.imprime();
		
		System.out.println("\n\nFila cheia: " + f1.cheia());
		System.out.println("Fila vazia: " + f1.vazia() + "\n");
		
		f1.remove();
		f1.remove();
		f1.remove();
		f1.remove();
		f1.remove();
	}
}
