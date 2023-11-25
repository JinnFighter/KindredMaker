using Client;
using Client.MainMenu;
using UnityEngine;
using Zenject;

namespace Init
{
    public class InitMainMenu : MonoBehaviour
    {
        [SerializeField] private ViewMainMenu _viewMainMenu;

        private IController _controller;
        [Inject] private IControllerFactory _controllerFactory;

        private void Awake()
        {
            _controller = _controllerFactory.CreateController<ControllerMainMenu>(new ModelMainMenu(), _viewMainMenu);
        }

        private void Start()
        {
            _controller.Init();
        }

        private void OnDestroy()
        {
            _controller.Terminate();
        }
    }
}