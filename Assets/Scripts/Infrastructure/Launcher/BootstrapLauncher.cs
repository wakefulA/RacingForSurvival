using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Infrastructure.Launcher
{
    public class BootstrapLauncher : BaseLauncher
    {
        private ISceneLoadingService _sceneLoadingService;

        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

        protected override void Launch()
        {
            Debug.LogError($"{nameof(BootstrapLauncher)} Launch");
            _sceneLoadingService.Load(MenuLauncher.SceneName);
        }
    }
}