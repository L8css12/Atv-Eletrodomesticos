namespace Atv_Eletrodomesticos.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela {  get; set; }
        public bool EhSmart { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico}, Tela: {TamanhoTela}, Smart: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
