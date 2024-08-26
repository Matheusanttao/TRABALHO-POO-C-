using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace TrabalhoFinalPOO
{
    public class GerenciadorDeClientes
    {
        private List<Cliente> clientes;

        public GerenciadorDeClientes()
        {
            clientes = new List<Cliente>();
            CarregarClientesDeXML();
        }

        public List<Cliente> ObterClientes()
        {
            return clientes;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            SalvarClientesEmXML();
        }

        public bool ValidarCliente(Cliente cliente, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (cliente.Id <= 0)
            {
                mensagemErro = "O ID deve ser um número maior que zero.";
                return false;
            }

            if (clientes.Any(c => c.Id == cliente.Id))
            {
                mensagemErro = "Este ID já está sendo usado por outro cliente.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                mensagemErro = "O nome do cliente é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Telefone))
            {
                mensagemErro = "O telefone do cliente é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.CPFCNPJ))
            {
                mensagemErro = "O CPF/CNPJ do cliente é obrigatório.";
                return false;
            }

            var endereco = cliente.Endereço;
            if (string.IsNullOrWhiteSpace(endereco.Rua))
            {
                mensagemErro = "A rua do endereço é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.Numero))
            {
                mensagemErro = "O número do endereço é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.Bairro))
            {
                mensagemErro = "O bairro do endereço é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.UF))
            {
                mensagemErro = "O UF do endereço é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.Cidade))
            {
                mensagemErro = "A cidade do endereço é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.CEP))
            {
                mensagemErro = "O CEP do endereço é obrigatório.";
                return false;
            }

            return true;
        }
        public void RemoverCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
            SalvarClientesEmXML();
        }
        public Cliente ProcurarClientePorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        private void CarregarClientesDeXML()
        {
            try
            {
                string CaminhoArquivo = @"C:\arquivoxml\clientes.xml";
                if (File.Exists(CaminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
                    using (TextReader reader = new StreamReader(CaminhoArquivo))
                    {
                        clientes = (List<Cliente>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao carregar os clientes.", ex);
            }
        }

        public void SalvarClientesEmXML()
        {
            try
            {
                string diretorio = @"C:\arquivoxml";
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string filePath = Path.Combine(diretorio, "clientes.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, clientes);
                }
            }
            catch (Exception ex)
            {
             
                throw new Exception("Ocorreu um erro ao salvar os clientes.", ex);
            }
        }
    }

}
