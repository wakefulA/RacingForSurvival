using Zenject;

namespace Mission
{
    public class MissionChekerInstaller : Installer<MissionChekerInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IMissionCheker>().To<MissionCheker>().AsSingle();
        }
    }
}