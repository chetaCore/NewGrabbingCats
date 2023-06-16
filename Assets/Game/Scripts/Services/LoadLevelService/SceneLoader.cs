using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Game.Scripts.State
{
    public class SceneLoader
    {
        private readonly ICorutineRunner _coruoutineRunner;

        public SceneLoader(ICorutineRunner coruoutineRunner) =>
            _coruoutineRunner = coruoutineRunner;

        public void Load(String name, Action onLoaded = null) =>
            _coruoutineRunner.StartCoroutine(LoadScene(name, onLoaded));

        public IEnumerator LoadScene(String nextScene, Action onLoaded = null)
        {
            AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Single);

            while (!waitNextScene.isDone)
                yield return null;

            onLoaded?.Invoke();
        }
    }
}