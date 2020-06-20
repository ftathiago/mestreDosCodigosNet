using System;

namespace exercicio01
{
    public class ExemploDispose : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose()");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //Implementando padrão disposable
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Dispose(bool)");
            if (disposed)
            {
                Console.WriteLine("Dispose já foi invocao antes. Posso sair sem alterar nada");
                return;
            }

            Console.WriteLine("  Devo liberar os recursos não gerenciados, independente do valor de disposing");
            if (disposing)
            {
                Console.WriteLine("  Estou sendo chamado pelo Dispose");
                Console.WriteLine("     Liberar os objetos gerenciados que implementam IDisposable");
                Console.WriteLine("     Liberar os objetos gerenciados que consomem muita memória ou recursos escassos");
            }
            else
                Console.WriteLine("  Estou sendo chamado pelo finalize");

        }
    }
}