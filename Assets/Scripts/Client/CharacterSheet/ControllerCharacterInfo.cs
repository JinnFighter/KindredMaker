using Reactivity;

namespace Client.CharacterSheet
{
    public class ControllerCharacterInfo : BaseController<IModelCharacterInfo, ViewCharacterInfo>
    {
        protected override void InitInner()
        {
            SubscriptionAggregator.ListenEvent(Model.CharacterName, HandleCharacterNameChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Sect, HandleSectChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Clan, HandleClanChanged, true);

            SubscriptionAggregator.ListenEvent(Model.PlayerName, HandlePlayerNameChanged, true);
            SubscriptionAggregator.ListenEvent(Model.PredatorType, HandlePredatorTypeChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Generation, HandleGenerationChanged, true);

            SubscriptionAggregator.ListenEvent(Model.ChronicleName, HandleChronicleNameChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Ambition, HandleAmbitionChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Desire, HandleDesireChanged, true);
        }

        private void HandleDesireChanged(object sender, GenericEventArg<string> e)
        {
            View.TextDesire.text = e.Value;
        }

        private void HandleAmbitionChanged(object sender, GenericEventArg<string> e)
        {
            View.TextAmbition.text = e.Value;
        }

        private void HandleChronicleNameChanged(object sender, GenericEventArg<string> e)
        {
            View.TextChronicleName.text = e.Value;
        }

        private void HandleGenerationChanged(object sender, GenericEventArg<int> e)
        {
            View.TextGeneration.text = e.Value.ToString();
        }

        private void HandlePredatorTypeChanged(object sender, GenericEventArg<string> e)
        {
            View.TextPredatorType.text = e.Value;
        }

        private void HandlePlayerNameChanged(object sender, GenericEventArg<string> e)
        {
            View.TextPlayerName.text = e.Value;
        }

        private void HandleClanChanged(object sender, GenericEventArg<string> e)
        {
            View.TextClan.text = e.Value;
        }

        private void HandleSectChanged(object sender, GenericEventArg<string> e)
        {
            View.TextSect.text = e.Value;
        }

        private void HandleCharacterNameChanged(object sender, GenericEventArg<string> e)
        {
            View.TextCharacterName.text = e.Value;
        }
    }
}