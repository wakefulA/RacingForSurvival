using Zenject;

namespace Infrastructure.Launcher.Services.Input
{
    public class InputServiceInstaller : Installer<InputServiceInstaller>

    {
        public override void InstallBindings()
        {
            Container
                .Bind<IInputService>()
                .To<PlayerMove>()
                .FromNewComponentOnNewGameObject()
                .AsSingle()
                .NonLazy();
        }
    }
}