public class Fila {
    int[] dados;
    int tamanho;
    int i = 0;
    
    Fila(int c){
        dados = new int[c];
        tamanho = c;
    }
    
    public boolean cheia(){
        return(dados[tamanho-1] != 0 );
    }
    
    public boolean vazia(){
        return(dados[0] == 0);
    }
    
    public void adiciona(int e){
        if(cheia()){
            System.out.println("\nFila cheia. Item [" + e + "] não adicionado.");
        } else {
            dados[i] = e;
            i++;
            System.out.println("Item [" + e + "] adicionado à fila.");
        }
    }
    
    public void remove(){
        if(vazia()){
            System.out.println("\nFila vazia. Adicione itens à fila.");
        } else {
            int removido = 0;
            i--;
            removido = dados[i];
            System.out.println("Item [" + removido + "] removido da fila.");
            dados[i] = 0;
        }
    }
    
    public void imprime(){
        System.out.print("\nFila atual: ");
        for(int a = 0; a < i; a++){
            System.out.print("[" + dados[a] + "]");
        }
    }
}