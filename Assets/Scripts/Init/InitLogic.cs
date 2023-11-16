using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Init
{
    public class InitLogic : MonoBehaviour
    {
        private async void Awake()
        {
            await BindServices();
            await InitServices();

            DontDestroyOnLoad(this);
            await SceneManager.LoadSceneAsync("CharacterSheet").ToUniTask();
        }

        private async void OnApplicationQuit()
        {
            await DestroyServices();
        }

        private UniTask BindServices()
        {
            return UniTask.CompletedTask;
        }

        private UniTask InitServices()
        {
            return UniTask.CompletedTask;
        }

        private UniTask DestroyServices()
        {
            return UniTask.CompletedTask;
        }
    }
}