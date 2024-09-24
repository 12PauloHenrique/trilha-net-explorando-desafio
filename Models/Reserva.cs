namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // Código implementado
            
            int capacidade = Suite.Capacidade;
            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Código implementado
                throw new ArgumentException("A quantidade de hóspedes é maior que a capacidade da suite.");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Código implementado
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            //Código implementado
            decimal valorDiaria = DiasReservados*Suite.ValorDiaria;

            //Código implementado
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valorDiaria = valorDiaria-valorDiaria*10/100;
            }

            return valorDiaria;
        }
    }
}