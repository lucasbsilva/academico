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