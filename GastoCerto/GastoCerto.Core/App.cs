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

            var previsaoGastoRespositorio = new PrevisaoGastoRepositorio();
            previsaoGastoRespositorio.Init();

            Mvx.RegisterSingleton(previsaoGastoRespositorio);
				
            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}