public class Pilha{
    int[] dados;
    int topo;
    int capacidade;
    
    Pilha(int c){
        topo = -1;
        dados = new int[c];
        capacidade = c;
    }
    
    public boolean cheia(){
        return(topo == capacidade-1);
    }
    
    public boolean vazia(){
        return(topo == -1);
    }
    
    public void empilha(int e){
        if(cheia()){
            System.out.println("\nPilha cheia. Item [" + e + "] não inserido na pilha.");
        } else {
            topo++;
            dados[topo] = e;
            System.out.println("Item empilhado: " + e);
        }
    }
    
    public void desempilha(){
        int removido = 0;
        if(vazia()){
            System.out.println("\nPilha vazia!");
        } else {
            removido = dados[topo];
            dados[topo] = 0;
            topo--;
            System.out.println("\nItem removido da pilha: " + removido);
        }
    }
    
    public void imprime(){
        if(vazia()){
            System.out.println("\nLista vazia!");
        } else
        
        System.out.println("\nPilha atual:");
        for(int i = topo; i > -1; i--){
            System.out.println(dados[i]);
        }
    }
}