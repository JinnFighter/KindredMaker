using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Init
{
    public class InitLogic : MonoBehaviour
    {
        [SerializeField] private string _sceneName;
        private async void Awake()
        {
            await SceneManager.LoadSceneAsync(_sceneName).ToUniTask();
        }
    }
}