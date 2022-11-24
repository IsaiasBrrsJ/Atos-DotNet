using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace SerializaBinario
{
    public partial class Form1 : Form
    {
        string caminhoArq = @"D:\Atos-Codigos\praticando-SERIALIZAÇÂO\SerializaBinario\Serializado\dados.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            string texto = txtSerializar.Text;
            
            FileStream fs = new FileStream(caminhoArq, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, texto);
            fs.Close();
            MessageBox.Show("Serializado com sucesso");

            txtSerializar.Clear();
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(caminhoArq, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            txtSerializar.Text = (string)bf.Deserialize(fs);
            fs.Close();
        }

        private void btnSerializaJson_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Isaias";
            p.sobrenome = "Jesus";
            p.endereco = new List<Endereco>()
            {
               new Endereco(){rua = "tetste", numero = 5070, bairro ="teste", cep ="768878-*888", estado ="Acre"},
               new Endereco(){rua = "Rua dos morrinhos", numero = 8850, bairro ="Arica", cep ="76824-188", estado ="Ariquemes"}
            };

            var js = new JsonSerializer();
            StreamWriter writer = new StreamWriter(caminhoArq);
            JsonWriter jsonWriter = new JsonTextWriter(writer);
            js.Serialize(jsonWriter, p);

            writer.Close();
            jsonWriter.Close();

            MessageBox.Show("Sucesso");
            txtJson.Text = File.ReadAllText(caminhoArq);


        }

        private void btnDesJson_Click(object sender, EventArgs e)
        {
            txtJson.Text = File.ReadAllText(caminhoArq);

            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(txtJson.Text);
        }
    }
}