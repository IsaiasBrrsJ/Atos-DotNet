using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Exec001
{
    public partial class Form1 : Form
    {
        #region ATIVIDADE
        /*
         1) Criar um formulário com Windows Form para serializar (3 formas importantes: xml, soap e json) dados de pacientes
            Classe Paciente 
            string nome
            DateTime dataNascimento
            string cpf

            No formulário, o usuário vai preencher textboxs dos dados de pacientes n vezes necessárias. 
            Sugestão: armazenar os dados dos pacientes em uma lista ou dataGrid e só depois depositar/serializar xml, soap e json


            2) Criar um segundo formulário com Windows Form que abre os arquivos (3 formas: xml, soap e json) com
            dados de pacientes. Pode ser um arquivo por vez ou um formulário por serializador.
            Uma vez aberto o(s) arquivo(s), popular os dados serializados em um dataGrid ou listView
        */
        #endregion
        string arqCaminho = @"D:\Atos-Codigos\praticando-SERIALIZAÇÂO\Exec001\dds\dados.txt";
        Paciente p;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJson_Click(object sender, EventArgs e)
        {

            if (!File.Exists(arqCaminho)) { File.Create(arqCaminho).Close(); }

            p = new Paciente(txtNome.Text, dataTxt.Value, maskTxtCpf.Text.Replace(",", "").Replace("-", ""));
            JsonSerializer jsSeria = new JsonSerializer();
            StreamWriter wri = new StreamWriter(arqCaminho);
            JsonWriter jsW = new JsonTextWriter(wri);

            jsSeria.Serialize(jsW, p);
           
            wri.Close();
            jsW.Close();


        }
    }
}