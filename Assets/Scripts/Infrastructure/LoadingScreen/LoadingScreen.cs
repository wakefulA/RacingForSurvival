using System;
using System.Collections;
using Infrastructure.Launcher;
using Infrastructure.Launcher.Services.SceneLoading;
using Services.Coroutine;
using Services.SceneLoading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Infrastructure.LoadingScreen
{
    [Serializable]
    public class LoadingScreen : MonoBehaviour, ICoroutineRunner
    {
        public Image loadingImage;
        [SerializeField] TextMeshProUGUI progressText;

        //private readonly ICoroutineRunner _coroutineRunner;

        // private ISceneLoadingService _sceneLoadingService;

        //[Inject]

        // public void Construct(ISceneLoadingService sceneLoadingService)
        //{

        //  _sceneLoadingService = sceneLoadingService;
        // }

        ////protected void Launch()
        //{
        //   _sceneLoadingService.Load(GameLauncher.SceneName);
        //}

        // public  LoadingScreen (ICoroutineRunner coroutineRunner)
        // {
        // _coroutineRunner = coroutineRunner;
        //}

        //Start 

        public void Start()
        {
            StartCoroutine(AsyncLoad(sceneName: "SampleScene"));
        }

        private IEnumerator AsyncLoad(string sceneName)

        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

            while (!operation.isDone)
            {
                float progress = operation.progress / 0.91f;
                loadingImage.fillAmount = progress;
                progressText.text = string.Format("{0:0}%", progress * 100); // прогресс без плавающей запятой


                yield return null;
            }
        }

        //[Inject]
        // public void Construct(ILoadingScreenService loading)
        //{
        //   _loading = loading;
        //}

        //private readonly ICoroutineRunner _coroutineRunner;

        // public LoadingScreen (ICoroutineRunner coroutineRunner)
        //{
        //    _coroutineRunner = coroutineRunner;
        //}

        //public void Load(string sceneName) =>
        //_coroutineRunner.StartCoroutine(AsyncLoad(sceneName));

        // [Inject]

        // public void Construct(ILoadingScreenService loadingScreenService)
        // {

        //  _loadingScreenService = loadingScreenService;
        // }

        //  [Header("Load scene")]
        //  [SerializeField ]public int sceneID;

        // private GameObject _loadingScreen;
    }
}