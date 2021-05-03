namespace Pesquisa_Selecao {
    class ClassPesquisaSelecao {
        /// <summary>
        /// Método (Função) que recebe um array de inteiros e um valor a procurar dentro desse array
        /// e devolve -1 se não existir o valor ou devolve o indice do array onde está o valor
        /// </summary>
        /// <param name="vetor"></param>
        /// <param name="valorProcurar"></param>
        /// <returns></returns>
        public static int PesquisaSequencial(int[] vetor, int valorProcurar) {
            int n = vetor.Length;

            for (int i = 0; i < n; i++) {
                if (vetor[i] == valorProcurar) {
                    return i;
                }
            }

            // não encontrou -> codigo -1
            return -1;
        }

        public static int PesquisaBinaria(int[] vetor, int valorProcurar) {
            int n = vetor.Length;

            int inf = 0;
            int sup = n - 1;
            int meio;

            while (inf <= sup) {
                meio = (inf + sup) / 2;

                if (vetor[meio] == valorProcurar) {
                    return meio;
                } else {
                    if (vetor[meio] < valorProcurar) {
                        inf = meio + 1;
                    } else {
                        sup = meio - 1;
                    }
                }
            }
            // não encontrou -> codigo -1
            return -1;
        }

    }
}
