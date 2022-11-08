using Player;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class ProjectInstallerr : MonoInstaller
    {
        public override void InstallBindings()
        {
           Debug.LogError($"ProjectInstaller InstallBindings");
           MoveServiceInstaller.Install(Container);
         
        }
    }
}