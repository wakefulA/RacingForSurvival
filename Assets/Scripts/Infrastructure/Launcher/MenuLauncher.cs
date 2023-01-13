using Infrastructure.Launcher.Services.SceneLoading;
using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Infrastructure.Launcher
{
    public class MenuLauncher : BaseLauncher
    {
        private ISceneLoadingService _sceneLoadingService;
        public const string SceneName = SceneNames.MenuScene;

        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

        protected override void Launch()
        {
            _sceneLoadingService.SetLauncher(this);
            Debug.LogError($"{nameof(MenuLauncher)} Launch");
            IsReady = true;
        }
    }
}