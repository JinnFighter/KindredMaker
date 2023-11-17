using Client.CharacterSheet;
using UnityEngine;

namespace Init
{
    public class InitCharacterSheet : MonoBehaviour
    {
        [SerializeField] private ViewCharacterSheet _viewCharacterSheet;

        private ControllerCharacterSheet _controllerCharacterSheet;

        private void Awake()
        {
            _controllerCharacterSheet =
                new ControllerCharacterSheet(new ModelCharacterSheet(), _viewCharacterSheet);
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