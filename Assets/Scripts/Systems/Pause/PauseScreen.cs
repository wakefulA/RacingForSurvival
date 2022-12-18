using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Systems.Pause
{
    public class PauseScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _innerObject;

        [SerializeField] private Button _resumeButton;
        [SerializeField] private Button _quitButton;
        [SerializeField] private Button _menuButton;

        [SerializeField] private GameObject _backToGame;

        private IPauseService _pauseService;

        [Inject]
        public void Construct(IPauseService pauseService)
        {
            _pauseService = pauseService;
        }

        private void Awake()
        {
            _innerObject.SetActive(false);
            _resumeButton.onClick.AddListener(OnResumeButton);
            _quitButton.onClick.AddListener(OnQuitButton);
            _menuButton.onClick.AddListener(OnMenuButtonClicked);
        }

        private void Start()
        {
            
            _pauseService.OnChanged += PausedChanged;
            _backToGame.SetActive(false);
        }

        private void OnDestroy()
        {
            _pauseService.OnChanged -= PausedChanged;
        }

        private void PausedChanged(bool isPaused)
        {
            _innerObject.SetActive(isPaused);
        }

        private void OnResumeButton()
        {
            _innerObject.SetActive(false);
            Time.timeScale = 1f;
        }

        private void OnQuitButton()
        {
            Debug.LogError("The end");
            Application.Quit();

            // _innerObject.GetComponent<>().interactable = false;
        }

        private void OnMenuButtonClicked()
        {
            _backToGame.SetActive(true);
        }
    }
}