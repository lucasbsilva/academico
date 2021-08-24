public class ListaInteiros{
    // atributos, propriedades
    int dados[];
    int tamanho;
    int capacidade;
    
    // método construtor
    ListaInteiros(int x) {  // "x" é parâmetro
        dados = new int[x];
        capacidade = x;
    }
    
    public boolean vazia(){
        return tamanho == 0;
    }
    
    public boolean cheia(){
        return tamanho == capacidade;
    }
    
    public void adicionaFinal(int item){    // métodos "void" não retornam valores
        if (cheia()){
            System.out.println("Lista cheia! Item (" + item + ") não incluido.");
        } else {
            dados[tamanho] = item;
            tamanho++;
            System.out.println("\nItem [" + item + "] adicionado ao final da lista.");
        }
    }
    
    public void adicionaInicio(int item){
        if (cheia()){
            System.out.println("Lista cheia, não é possível adicionar mais itens.");
        } else {
            
            for(int i = tamanho; i > 0; i--){
                dados[i] = dados[i-1];
            }
            dados[0] = item;
            tamanho++;
            System.out.println("\nItem [" + item + "] adicionado ao inicio da lista.");
        }
    }
    
    public int removerFinal(){
        int itemRemovido = 0;
        if (vazia()){
            System.out.println("Não existem mais itens na lista.");
        } else {
            tamanho--;
            itemRemovido = dados[tamanho];
            dados[tamanho] = 0;
        }
        return itemRemovido;
    }
    
    public int removerInicio(){
        int itemRemovido = dados[0];
        
        if (vazia()){
            System.out.println("Lista vazia, item não removido.");
        } else {
            tamanho--;
            itemRemovido = dados[0];
            for(int i = 0; i < tamanho; i++){
                dados[i] = dados[i+1];
            }
        }
        return itemRemovido;
    }
    
    public void imprimir(){
        System.out.print("[");
        for (int cont = 0; cont < tamanho; cont++){
            System.out.print(dados[cont]);
            if(cont < tamanho-1)
                System.out.print(", ");
        }
        System.out.println("]");
    }
}