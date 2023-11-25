using Client;
using Client.CharacterSheet;
using Logic;
using UnityEngine;
using Zenject;
using CharacterInfo = Logic.CharacterInfo;

namespace Init
{
    public class InitCharacterSheet : MonoBehaviour
    {
        [SerializeField] private ViewCharacterSheet _viewCharacterSheet;

        private ControllerCharacterSheet _controllerCharacterSheet;

        [Inject] private IControllerFactory _controllerFactory;

        private void Awake()
        {
            var character = new Character(new CharacterInfo("TestName", "None", EClan.Malkavian, "TestPlayerName",
                EPredatorType.Sandman, 13, "TestChronicleName", "To Test", "To Be Tested"));

            _controllerCharacterSheet =
                _controllerFactory.CreateController<ControllerCharacterSheet>(new ModelCharacterSheet(character),
                    _viewCharacterSheet);
        }

        private void Start()
        {
            _controllerCharacterSheet.Init();
        }

        private void OnDestroy()
        {
            _controllerCharacterSheet.Terminate();
            _viewCharacterSheet = null;
        }
    }
}