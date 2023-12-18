namespace Atividade{
    class PessoaJuridica : Clientes{
        public string cnpj {get; set;}
        public string inscricao_estadual{get; set;}

        public override void Pagar_Imposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}