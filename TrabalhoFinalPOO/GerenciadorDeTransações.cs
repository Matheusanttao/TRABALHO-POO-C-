using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public class GerenciadorDeTransações
    {
        private List<Transação> transações;
        private string caminhoArquivo = @"C:\arquivoxml\Transações.xml";

        public GerenciadorDeTransações()
        {
            transações = new List<Transação>();
            CarregarTransações(); // Carrega as transações do arquivo XML ao inicializar
     
        }

        public void AdicionarTransação(Transação transação)
        {
            if (VerificarCamposPreenchidos(transação))
            {
                transações.Add(transação);
                SalvarTransações();
            }
            else
            {
                Console.WriteLine("Todos os campos devem ser preenchidos.");
            }
        }

        public bool VerificarCamposPreenchidos(Transação transação)
        {
            return !string.IsNullOrWhiteSpace(transação.IdVenda) &&
                   !string.IsNullOrWhiteSpace(transação.Vendedor) &&
                   !string.IsNullOrWhiteSpace(transação.PreçoT) &&
                   !string.IsNullOrWhiteSpace(transação.Pagamento) &&
                   !string.IsNullOrWhiteSpace(transação.ObservaçõesAdicionaisT);
        }

        public List<Transação> ObterTransações()
        {
            return transações;
        }

        public void SalvarTransações()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Transação>));
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, transações);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar transações: {ex.Message}");
            }
        }

        private void CarregarTransações()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Transação>));
                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        transações = (List<Transação>)serializer.Deserialize(reader);
                    }
                }
                else
                {
                    Console.WriteLine("Arquivo de transações não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar transações: {ex.Message}");
            }
        }

        public Transação BuscarTransaçãoPorId(string id)
        {
           
            Transação transaçãoEncontrada = transações.Find(t => t.IdVenda == id);

            if (transaçãoEncontrada == null)
            {
                Console.WriteLine($"Transação com ID '{id}' não encontrada.");
            }

            return transaçãoEncontrada;
        }
        public void RemoverTransação(Transação transação)
        {
            transações.Remove(transação); // Remove a transação da lista de transações
            SalvarTransações(); // Salva as alterações após remover a transação
        }

    }
}
