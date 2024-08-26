using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public class GerenciadorDeCarros
    {
        private List<Carro> carros;
        private string caminhoArquivo = @"C:\arquivoxml\carros.xml";

        public GerenciadorDeCarros()
        {
            carros = new List<Carro>();
            CarregarCarrosDeXML();
        }

        public List<Carro> ObterCarros()
        {
            return carros;
        }

        public void AdicionarCarro(Carro carro)
        {
            if (!PlacaJaCadastrada(carro.Placa))
            {
                carros.Add(carro);
                SalvarCarrosEmXML();
            }
            else
            {
                throw new InvalidOperationException("A placa já está cadastrada.");
            }
        }

        public void RemoverCarro(string placa)
        {
            Carro carro = ProcurarCarroPorPlaca(placa);
            if (carro != null)
            {
                carros.Remove(carro);
            }
        }


        public Carro ProcurarCarroPorPlaca(string placa)
        {
            string placaUpper = placa.ToUpper();
            return carros.FirstOrDefault(c => c.Placa.ToUpper() == placaUpper);
        }

        public bool PlacaJaCadastrada(string placa)
        {
            string placaUpper = placa.ToUpper();
            return carros.Any(c => c.Placa.ToUpper() == placaUpper);
        }

        private void CarregarCarrosDeXML()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
                    using (TextReader reader = new StreamReader(caminhoArquivo))
                    {
                        carros = (List<Carro>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os carros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carros = new List<Carro>();
            }
        }

        public void SalvarCarrosEmXML()
        {
            try
            {
                string diretorio = Path.GetDirectoryName(caminhoArquivo);
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
                using (TextWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, carros);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os carros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarCampos(Carro carro, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(carro.Placa))
            {
                mensagemErro = "A placa é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Marca))
            {
                mensagemErro = "A marca é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Modelo))
            {
                mensagemErro = "O modelo é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Ano))
            {
                mensagemErro = "O ano é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Preço))
            {
                mensagemErro = "O preço é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Chassi))
            {
                mensagemErro = "O chassi é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Km))
            {
                mensagemErro = "A quilometragem é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(carro.Categoria))
            {
                mensagemErro = "A categoria é obrigatória.";
                return false;
            }

            return true;
        }
    }
}
