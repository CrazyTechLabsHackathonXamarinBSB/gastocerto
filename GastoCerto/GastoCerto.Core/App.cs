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

            var previsaoGastoRepositorio = new PrevisaoGastoRepositorio();
            previsaoGastoRepositorio.Init();
            Mvx.RegisterSingleton(previsaoGastoRepositorio);

            var despesaRepositorio = new DespesaRepositorio();
            despesaRepositorio.Init();
            Mvx.RegisterSingleton(despesaRepositorio);

            RegisterAppStart<ViewModels.PrincipalViewModel>();
        }
    }
}