using Services.SceneLoading;

namespace Infrastructure.Launcher
{
    public class GameLauncher : BaseLauncher
    {
        protected override void Launch()
        {
            //IsReady = true;
        }

        public const string SceneName = SceneNames.Game;

    }
}