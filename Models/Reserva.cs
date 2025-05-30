namespace DesafioProjetoHospedagem.Models
{
    /// <summary>
    /// Classe para reserva de suíte
    /// </summary>
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
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade de hóspedes não pode ultrapassar a quantidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal calculoDiaria = this.DiasReservados * Suite.ValorDiaria;
            decimal valor = calculoDiaria;

            if(this.DiasReservados >= 10)
            {
                decimal calculoDiariaComDesconto = calculoDiaria - (calculoDiaria * (decimal)0.10); //uso de casting pra converção de double pra decimal
                valor = calculoDiariaComDesconto;
            }

            return valor;
        }
    }
}