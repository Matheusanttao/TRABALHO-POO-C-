using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public class GerenciadorEstoqueDeCarros
    {
        private List<Carro> carrosNoEstoque;
        private string caminhoArquivo = @"C:\arquivoxml\EstoqueCarros.xml";

        public GerenciadorEstoqueDeCarros()
        {
            carrosNoEstoque = new List<Carro>();
            CarregarEstoque();
        }

        public void AdicionarCarro(Carro carro)
        {
            carrosNoEstoque.Add(carro);
            SalvarEstoque();
        }

        public void AdicionarCarroComprado(Carro carro)
        {
            AdicionarCarro(carro); // Reutiliza o método AdicionarCarro para adicionar carros comprados
        }

        public Carro ProcurarCarroPorPlaca(string placa)
        {
            return carrosNoEstoque.Find(c => c.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
        }
        public Carro ProcurarCarroCompradoPorPlaca(string placa)
        {
            return carrosNoEstoque.FirstOrDefault(c => c.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
        }

        public void RemoverCarroComprado(string placa)
        {
            Carro carro = carrosNoEstoque.Find(c => c.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
            if (carro != null)
            {
                carrosNoEstoque.Remove(carro);
                SalvarEstoque();
            }
        }

        public void SalvarEstoque()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, carrosNoEstoque); // Salva a lista de carros no arquivo XML
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar estoque: {ex.Message}");
            }
        }

        private void CarregarEstoque()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        carrosNoEstoque = (List<Carro>)serializer.Deserialize(reader); // Carrega os carros do XML para a lista em memória
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar estoque: {ex.Message}");
            }
        }
    }
}
