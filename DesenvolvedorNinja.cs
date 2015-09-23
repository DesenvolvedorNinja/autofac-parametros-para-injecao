namespace AutofacDemoWin
{
    public class DesenvolvedorNinja : IDesenvolvedor
    {
        private ILinguagemProgramacao _linguagemProgramacao;

        public DesenvolvedorNinja(ILinguagemProgramacao linguagemProgramacao)
        {
            this._linguagemProgramacao = linguagemProgramacao;
        }

        public string GetLinguagemProgramacao()
        {
            return _linguagemProgramacao.Nome;
        }
    }
}
