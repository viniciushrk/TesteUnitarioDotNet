using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario
{
    public class AdicionarCarroService
    {
        public Carro Executar(string nome)
        {
            if(nome == null)
            {
                throw new ArgumentNullException(nome);
            }

            Carro carro = new Carro(Guid.NewGuid(), nome);

            return carro;
        }
    }
}
