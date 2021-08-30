public class Main
{
	public static void main(String[] args) {
		
		String expressao = "50+((120*7)+(30/2))-100";
		char[] dados = expressao.toCharArray();
		boolean correta = true;
		
		PilhaChar pilha = new PilhaChar(dados.length);
		
		for (char item: dados){
		    if(item == '('){
                pilha.empilha(item);		        
		    } else if(item == ')'){
		        if(!pilha.vazia()){
		            pilha.desempilha();
		        } else {
		            correta = false;
		            break;
		        }
		    }
		}
		
		if(pilha.vazia() && correta){
		    System.out.println("Expressão corretamente balanceada.");
		} else {
		    System.out.println("Expressão não balanceada, revise-a!");
		}
	}
}