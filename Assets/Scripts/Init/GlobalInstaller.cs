using Client;
using Logic.Services;
using Zenject;

namespace Init
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IDiceRollerService>().To<DiceRollerService>().AsSingle();
            Container.Bind<IControllerFactory>().To<ControllerFactory>().AsSingle();
        }
    }
}