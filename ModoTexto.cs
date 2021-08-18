using System;

namespace poo_static {

    class ModoTexto {

        static public String Leia() {
            return Console.ReadLine();
        }

        static public String Leia(String texto) {
            Console.Write(texto);
            return Console.ReadLine();
        }

        static public void Escrever(string texto) {
            Console.WriteLine(texto);
        }

        static public void Pausar() {
            Console.ReadKey();
        }
    }
}
