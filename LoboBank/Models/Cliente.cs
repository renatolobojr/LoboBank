namespace LoboBank.Models
{
    internal class Cliente
    {
        private string documento;

        public int Id { get; set; }
        public string Nome { get; set; }
        public Pessoa Pessoa { get; set; }
        public String? Documento
        {
            get => documento;
            set
            {
                if (value is not null) documento = value;
                else documento = "doc não informado";
                string teste = "teste";
                var t = teste.Contains("e");
                List<string> tesouro = new();
                tesouro.Add("teste");
                var e = tesouro.Count;
                var x = Console.ReadLine();
            }
        }

        public Cliente(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }
    }

    enum Pessoa
    {
        fisica,
        juridica
    }
}