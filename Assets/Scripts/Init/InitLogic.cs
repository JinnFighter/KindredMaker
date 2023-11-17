using Cysharp.Threading.Tasks;
using Logic.Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Init
{
    public class InitLogic : MonoBehaviour
    {
        private async void Awake()
        {
            var container = ProjectContext.Instance.Container;
            await BindServices(container);
            await InitServices(container);

            DontDestroyOnLoad(this);
            await SceneManager.LoadSceneAsync("CharacterSheet").ToUniTask();
        }

        private async void OnApplicationQuit()
        {
            await DestroyServices();
        }

        private UniTask BindServices(DiContainer container)
        {
            container.Bind<IDiceRollerService>().To<DiceRollerService>().AsSingle();
            return UniTask.CompletedTask;
        }

        private UniTask InitServices(DiContainer container)
        {
            return UniTask.CompletedTask;
        }

        private UniTask DestroyServices()
        {
            return UniTask.CompletedTask;
        }
    }
}