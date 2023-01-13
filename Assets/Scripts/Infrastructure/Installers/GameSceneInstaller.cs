using Infrastructure.Launcher.Services.Input;
using Player.PlayerHealth;
using Systems.Pause;
using Zenject;

namespace Infrastructure.Installers
{
    public class GameSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            PauseServiceInstaller.Install(Container);
            InputServiceInstaller.Install(Container);
        }
    }
}