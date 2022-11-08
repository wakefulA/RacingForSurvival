using Player;
using UnityEngine;
using Zenject;

namespace Infrastructure.Launcher
{
    public class BootstrapLauncher : BaseLauncher
    {

        private IPlayerMove _playerMove;

        [Inject]

        public void Construct(IPlayerMove playerMove)
        {
            _playerMove = playerMove;
        }
        protected override void Launch()
        {
            Debug.LogError($"{nameof(BootstrapLauncher)} Launch");
            // TODO: Init

            //IsReady = true;
        }
        
    }
}