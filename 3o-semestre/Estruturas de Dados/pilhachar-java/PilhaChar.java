public class PilhaChar{
    char[] dados;
    int topo;
    int capacidade;
    
    PilhaChar(int c){
        topo = -1;
        dados = new char[c];
        capacidade = c;
    }
    
    public boolean cheia(){
        return(topo == capacidade-1);
    }
    
    public boolean vazia(){
        return(topo == -1);
    }
    
    public void empilha(char e){
        topo++;
        dados[topo] = e;
    }
    
    public void desempilha(){
        char removido =' ';
        removido = dados[topo];
        dados[topo] = 0;
        topo--;
    }
}