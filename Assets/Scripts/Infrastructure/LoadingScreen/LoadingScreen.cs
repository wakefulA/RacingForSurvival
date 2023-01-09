using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Infrastructure.LoadingScreen
{
    [Serializable]
    public class LoadingScreen : MonoBehaviour
    {
        public int sceneID;
        public Image loadingImage;
        [SerializeField] TextMeshProUGUI progressText;

        public void Start()
        {
            StartCoroutine(AsyncLoad());
        }

        private IEnumerator AsyncLoad()

        {
            
            
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
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
        //   _coroutineRunner.StartCoroutine(AsyncLoad(sceneName));

        // [Inject]

        //  public void Construct(ILoadingScreenService loadingScreenService)
        //{

        //   _loadingScreenService = loadingScreenService;

        //  }

        //  [Header("Load scene")]
        //  [SerializeField ]public int sceneID;

        // private GameObject _loadingScreen;
    }
}