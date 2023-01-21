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
        public Image loadingImage;
        [SerializeField] TextMeshProUGUI progressText;

        public void Start()
        {
            StartCoroutine(AsyncLoad(sceneName: "SampleScene"));
        }

        public IEnumerator AsyncLoad(string sceneName)

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
    }
}