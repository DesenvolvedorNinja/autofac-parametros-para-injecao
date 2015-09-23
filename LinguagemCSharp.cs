namespace AutofacDemoWin
{
    public class LinguagemCSharp : ILinguagemProgramacao
    {
        public string Nome
        {
            get
            {
                return "C#";
            }
        }

        public double Versao
        {
            get
            {
                return 4.6;
            }
        }
    }
}
