using System;
using UnityEngine;

namespace Systems.Pause
{
    public class PauseService : MonoBehaviour, IPauseService
    {
        //private static PauseService _instance;

        public event Action<bool> OnChanged;
        
        //public static PauseService Instance => _instance;
        public bool IsPaused { get; private set; }

        //private void Awake()
        //{
           // _instance = this;
            //DontDestroyOnLoad(gameObject);
        //}

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                TogglePause();
            }
        }

        private void TogglePause()
        {
            IsPaused = !IsPaused;
            Time.timeScale = IsPaused ? 0 : 1;
            OnChanged?.Invoke(IsPaused);
        }
    }
}