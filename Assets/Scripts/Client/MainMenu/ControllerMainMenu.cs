using UnityEngine.SceneManagement;

namespace Client.MainMenu
{
    public class ControllerMainMenu : BaseController<IModelMainMenu, ViewMainMenu>
    {
        protected override void InitInner()
        {
            SubscriptionAggregator.ListenEvent(View.ButtonCreateCharacter.Button.onClick, HandleButtonCreateCharacterClicked);
            SubscriptionAggregator.ListenEvent(View.ButtonCharacterSheet.Button.onClick, HandleButtonCharacterSheetClicked);
        }
        
        private void HandleButtonCreateCharacterClicked()
        {
            SceneManager.LoadScene("Scenes/CharacterBuilder");
        }

        private void HandleButtonCharacterSheetClicked()
        {
            SceneManager.LoadScene("Scenes/CharacterSheet");
        }
    }
}