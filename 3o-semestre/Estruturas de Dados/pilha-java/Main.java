public class Main
{
	public static void main(String[] args) {
	
	Pilha pilha = new Pilha(5);
	
	pilha.empilha(10);
	pilha.empilha(20);
	pilha.empilha(30);
	pilha.empilha(40);
	pilha.empilha(50);
	
	pilha.imprime();
	
	pilha.desempilha();
	pilha.desempilha();
	
	pilha.imprime();
	
	pilha.empilha(60);
	pilha.empilha(70);
	pilha.empilha(80);
	
	pilha.desempilha();
	pilha.desempilha();
	pilha.desempilha();
	pilha.desempilha();
	pilha.desempilha();
	pilha.desempilha();
	
	System.out.println("\nPilha cheia: " + pilha.cheia());
	System.out.println("Pilha vazia: " + pilha.vazia());
	}
}
