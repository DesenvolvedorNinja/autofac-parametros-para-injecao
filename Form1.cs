using Autofac;
using Autofac.Core;
using System;
using System.Windows.Forms;

namespace AutofacDemoWin
{
    public partial class FormAutofacDemoWin : Form
    {
        private IContainer _container;

        public FormAutofacDemoWin()
        {
            InitializeComponent();
        }

        private void buttonObterLinguagemDefault_Click(object sender, EventArgs e)
        {
            IDesenvolvedor desenvolvedor = new DesenvolvedorNinja(new LinguagemCSharp());
            MessageBox.Show(desenvolvedor.GetLinguagemProgramacao());
        }

        private void FormAutofacDemoWin_Load(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<LinguagemCSharp>().As<ILinguagemProgramacao>().AsSelf().InstancePerDependency();
            builder.RegisterType<LinguagemGO>().As<ILinguagemProgramacao>().AsSelf().InstancePerDependency();

            builder.RegisterType<DesenvolvedorNinja>().As<IDesenvolvedor>().WithParameter(new ResolvedParameter(
                (pi, ctx) => pi.ParameterType == typeof(ILinguagemProgramacao),
                (pi, ctx) => ctx.Resolve<LinguagemCSharp>())).InstancePerDependency();

            _container = builder.Build();
        }

        private void buttonObterLinguagemAutofac_Click(object sender, EventArgs e)
        {
            IDesenvolvedor desenvolvedor = _container.Resolve<IDesenvolvedor>();
            MessageBox.Show(desenvolvedor.GetLinguagemProgramacao());
        }
    }
}
