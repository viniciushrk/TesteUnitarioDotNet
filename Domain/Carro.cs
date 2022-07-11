namespace Domain
{
    public class Carro
    {
        public Carro(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public int QuantidadePorta { get; set; }
    }
}