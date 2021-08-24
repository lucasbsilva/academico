public class Main
{
    public static void main(String[] args) {
        
        ListaInteiros lista = new ListaInteiros(5);
        
        System.out.println("Estrutura de Dados (aula 16/08/21) - Lista com Alocação Estática\n");
        
        lista.adicionaFinal(7);
        lista.adicionaFinal(23);
        lista.adicionaFinal(12);
        lista.adicionaFinal(9);
        // lista.adicionaFinal(44);
        
        System.out.println("\nDados da lista:");
        lista.imprimir();
        
        lista.adicionaInicio(46);
        lista.imprimir();
        
        lista.removerInicio();
        lista.imprimir();
        
        System.out.println("\nTamanho da lista:       " + lista.tamanho);
        System.out.println("Capacidade da lista:    " + lista.capacidade);
        System.out.println("Lista vazia?            " + lista.vazia());
        System.out.println("Lista cheia?            " + lista.cheia() + "\n");
        
        /* System.out.println("Item removido: " + lista.removerFinal());
        
        System.out.println("\nDados da lista:");
        lista.imprimir();
        
        lista.adicionaFinal(46);
        System.out.println("\nItem adicionado: " + lista.dados[4]);
        
        System.out.println("\nDados da lista:");
        lista.imprimir();
        
        System.out.println("\nAo tentar incluir novo elemento na lista:");
        lista.adicionaFinal(112); // item que não será incluso na lista
        */
        
    }
}