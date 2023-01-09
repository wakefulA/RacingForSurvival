using Infrastructure.Launcher.Services.HP;
using Mission;
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
            MissionChekerInstaller.Install(Container);
           





        }
    }
}