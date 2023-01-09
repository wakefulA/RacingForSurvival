using Services.SceneLoading;
using Zenject;

namespace Infrastructure.Launcher.Services.HP
{
    public class HPServiceInstaller :  Installer<HPServiceInstaller>
    {

        public override void InstallBindings()
        {
            Container.Bind<HPService>().AsSingle();
        }
        
       
        
    }
}