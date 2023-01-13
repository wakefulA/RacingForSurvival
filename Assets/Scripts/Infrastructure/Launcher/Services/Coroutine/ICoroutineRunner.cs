using System.Collections;

namespace Infrastructure.Launcher.Services.Coroutine
{
    public interface ICoroutineRunner
    {
        UnityEngine.Coroutine StartCoroutine(IEnumerator enumerator);
    }
}