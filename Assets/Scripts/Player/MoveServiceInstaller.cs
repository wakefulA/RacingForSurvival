using Zenject;

namespace Player
{
    public class MoveServiceInstaller : Installer<MoveServiceInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlayerMove>().To<PlayerMove>().AsSingle();
        }
    }
}