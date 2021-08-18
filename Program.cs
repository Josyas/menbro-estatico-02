using System;

namespace poo_static {
    class Program {
        static void Main(string[] args) {

            String nome;
            // ModoTexto.Escrever("Qual é o seu nome: ");
            nome = ModoTexto.Leia("Qual é o seu nome: ");
            ModoTexto.Escrever("Alo, " + nome);
            ModoTexto.Pausar();
        }

        
    }
}
