using System.Collections.Generic;
using Client;
using Client.СharacterBuilder;
using Client.СharacterBuilder.Steps;
using UnityEngine;
using Zenject;

namespace Init
{
    public class InitCharacterBuilder : MonoBehaviour
    {
        [SerializeField] private ViewCharacterBuilder _viewCharacterBuilder;

        private IController _controllerCharacterBuilder;
        [Inject] private IControllerFactory _controllerFactory;

        private void Awake()
        {
            _controllerCharacterBuilder =
                _controllerFactory.CreateController<ControllerCharacterBuilder>(new ModelCharacterBuilder(
                        new List<IModelBuilderStep>
                        {
                            new ModelBuilderStepAttributes()
                        }),
                    _viewCharacterBuilder);
        }

        private void Start()
        {
            _controllerCharacterBuilder.Init();
        }

        private void OnDestroy()
        {
            _controllerCharacterBuilder.Terminate();
        }
    }
}