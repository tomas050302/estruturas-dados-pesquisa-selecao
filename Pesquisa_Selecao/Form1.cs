namespace Pesquisa_Selecao {
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form {
        // objetos (variavies) globais
        // estrutura de dados para os numeros -> array de inteiros
        /// <summary>
        /// Defines the arrayNumeros.
        /// </summary>
        internal int[] arrayNumeros;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// The btnCriarArray_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnCriarArray_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;


            int tamanho = int.Parse(numericNumeros.Value.ToString());

            arrayNumeros = new int[tamanho];

            if (radioButtonAleatorio.Checked) {
                Random random = new Random();

                for (int i = 0; i < tamanho; i++) {
                    int valor = random.Next(1, tamanho + 1);

                    arrayNumeros[i] = valor;
                }
            } else if (radioButtonOrdemCrescente.Checked) {
                for (int i = 0; i < tamanho; i++) {
                    arrayNumeros[i] = i + 1;
                }
            } else {
                for (int i = 0; i < tamanho; i++) {
                    arrayNumeros[i] = tamanho - i;
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);

            lblTempoCriar.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

            lstBoxNumeros.DataSource = arrayNumeros;

            btnPesquisaBinaria.Enabled = true;
            btnPesquisaSequencial.Enabled = true;
            txtValorProcurar.Enabled = true;
            txtValorContar.Enabled = true;
            btnMax.Enabled = true;
            btnMin.Enabled = true;
            btnKEsimoMax.Enabled = true;
            btnKEsimoMin.Enabled = true;
            btnMaxMin.Enabled = true;
            btnContar.Enabled = true;
            numericKNum.Enabled = true;
        }

        /// <summary>
        /// The Form1_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Form1_Load(object sender, EventArgs e) {
        }

        /// <summary>
        /// The btnPesquisaSequencial_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnPesquisaSequencial_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;

            int valor;

            bool sucesso = int.TryParse(txtValorProcurar.Text, out valor);

            if (valor <= 0)
                MessageBox.Show("O número deve ser válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (sucesso) {

                int pos = ClassPesquisaSelecao.PesquisaSequencial(arrayNumeros, valor);

                if (pos == -1) {
                    txtResultado.Text = $"O Número {valor} não existe no array";
                } else {
                    txtResultado.Text = $"O Número {valor} está na posição {pos}";
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);

            lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
        }

        /// <summary>
        /// The btnPesquisaBinaria_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnPesquisaBinaria_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;

            int valor;

            bool sucesso = int.TryParse(txtValorProcurar.Text, out valor);

            if (valor <= 0)
                MessageBox.Show("O número deve ser válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int[] sortedArray = new int[arrayNumeros.Length];
            Array.Copy(arrayNumeros, sortedArray, arrayNumeros.Length);

            Array.Sort(sortedArray); // The binary search needs the arary to be sorted to work

            if (sucesso) {
                ClassPesquisaSelecao.PesquisaBinaria(sortedArray, valor);

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);

                lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

                /*
                    First get the time for sorting and searching with binary searching to get the accurate time
                    Then use the built in function to get the indexOf the pos in the original array to get the
                    correct answer.
                */

                int pos = Array.IndexOf(arrayNumeros, valor);

                if (pos == -1) {
                    txtResultado.Text = $"O Número {valor} não existe no array";
                } else {
                    txtResultado.Text = $"O Número {valor} está na posição {pos}";
                }
            }


        }

        private void btnKEsimoMin_Click(object sender, EventArgs e) {
            /*
                If we get k = arrayNumeros.Length we would do n ^ k iterations in the code to get the max value in array.
                So, we use sort the array first. In C# the sorting algorithm used is QuickSorting, that gets in the worst
                case scenario n ^ 2 iterations, and the in minimum n log(n), so, for all k > 2 this algorithm will garantee
                better time complexity.
            */

            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;

            int[] sortedArray = new int[arrayNumeros.Length];
            Array.Copy(arrayNumeros, sortedArray, arrayNumeros.Length);

            Array.Sort(sortedArray);

            int k = int.Parse(numericKNum.Value.ToString());

            if (k < 1 || k > sortedArray.Length) {
                MessageBox.Show("O número deve ser um índice válido do array!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                int result = sortedArray[k - 1];

                lblResultadoKMin.Text = $"O K-Ésimo Menor Número é o: {result}";

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);

                lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
            }
        }

        private void btnContar_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;

            if (txtValorContar.Text == "")
                MessageBox.Show("Deve inserir um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                int n = int.Parse(txtValorContar.Text);
                int count = 0;

                for (int i = 0; i < arrayNumeros.Length; i++) {
                    if (arrayNumeros[i] == n) {
                        count++;
                    }
                }

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);

                lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

                lblResultadoContar.Text = $"O valor aparece {count} vezes.";
            }
        }

        private void btnMax_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;
            TempoI = DateTime.Now;

            int max = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++) {
                if (arrayNumeros[i] > max) {
                    max = arrayNumeros[i];
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);

            lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

            lblResultadoMax.Text = $"O Maior número é: {max}";
        }

        private void btnMin_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;

            TempoI = DateTime.Now;

            int min = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++) {
                if (arrayNumeros[i] < min) {
                    min = arrayNumeros[i];
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);

            lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

            lblResultadoMin.Text = $"O Menor número é: {min}";
        }

        private void btnKEsimoMax_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;

            TempoI = DateTime.Now;

            int[] sortedArray = new int[arrayNumeros.Length];
            Array.Copy(arrayNumeros, sortedArray, arrayNumeros.Length);

            Array.Sort(sortedArray);

            int k = int.Parse(numericKNum.Value.ToString());

            if (k < 1 || k > sortedArray.Length) {
                MessageBox.Show("O número deve ser um índice válido do array!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                int result = sortedArray[sortedArray.Length - k];

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);

                lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

                lblResultadoKMax.Text = $"O K-Ésimo Maior Número é o: {result}";
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e) {
            DateTime TempoI, TempoF;
            TimeSpan Tempo;

            TempoI = DateTime.Now;

            int max = arrayNumeros[0];
            int min = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++) {
                if (arrayNumeros[i] < min) {
                    min = arrayNumeros[i];
                }
            }

            for (int i = 1; i < arrayNumeros.Length; i++) {
                if (arrayNumeros[i] > max) {
                    max = arrayNumeros[i];
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);

            lblTempoPesquisas.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";

            lblResultadoMaxMin.Text = $"O valor máximo é: {max} e o minímo é: {min}";
        }
    }
}
