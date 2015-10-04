using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using GastoCerto.Core.Repositorio;

namespace GastoCerto.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            var previsaogastorepositorio = new previsaogastorepositorio();
            previsaogastorepositorio.init();
            mvx.registersingleton(previsaogastorepositorio);

            var despesarepositorio = new despesarepositorio();
            despesarepositorio.init();
            mvx.registersingleton(despesarepositorio);

            RegisterAppStart<ViewModels.AdicionarDespesaViewModel>();
        }
    }
}