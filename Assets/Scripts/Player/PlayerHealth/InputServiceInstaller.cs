using Zenject;

namespace Player.PlayerHealth
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