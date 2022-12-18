using Infrastructure.LoadingScreen;
using Services.Coroutine;
using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class ProjectInstallerr : MonoInstaller
    {
        public override void InstallBindings()
        {
           Debug.LogError($"ProjectInstaller InstallBindings");
           CoroutineRunnerInstaller.Install(Container);
           SceneLoadingServiceInstaller.Install(Container);
         
         
        }
    }
}