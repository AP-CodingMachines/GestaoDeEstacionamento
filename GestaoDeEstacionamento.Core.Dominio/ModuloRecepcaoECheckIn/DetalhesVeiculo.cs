using GestaoDeEstacionamento.Core.Dominio.Compartilhado;

namespace GestaoDeEstacionamento.Core.Dominio.ModuloRecepcaoECheckIn
{
    public class DetalhesVeiculo : EntidadeBase<DetalhesVeiculo>
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }  
        public string Cor { get; set; }

        public DetalhesVeiculo(){}

        public DetalhesVeiculo(string placa, string modelo, string cor) : this()
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
        }

        public override void AtualizarRegistro(DetalhesVeiculo registroEditado)
        {
            Placa = registroEditado.Placa;
            Modelo = registroEditado.Modelo;
            Cor = registroEditado.Cor;
        }
    }
}
