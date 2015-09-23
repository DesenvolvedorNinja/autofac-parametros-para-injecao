namespace AutofacDemoWin
{
    public class LinguagemGO : ILinguagemProgramacao
    {
        public string Nome
        {
            get
            {
                return "GO";
            }
        }

        public double Versao
        {
            get
            {
                return 1.5;
            }
        }
    }
}
