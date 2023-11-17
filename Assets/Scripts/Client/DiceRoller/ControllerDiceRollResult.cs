using Reactivity;

namespace Client.DiceRoller
{
    public class ControllerDiceRollResult : BaseController<IModelDiceRollResult, ViewDiceRollResult>
    {
        public ControllerDiceRollResult(IModelDiceRollResult model, ViewDiceRollResult view) : base(model, view)
        {
        }

        protected override void InitInner()
        {
            var diceCount = Model.RollResults.Count;
            for (var i = 0; i < View.ImagesDice.Count; i++)
            {
                var isActive = i < diceCount;
                View.ImagesDice[i].gameObject.SetActive(isActive);
                if (isActive) View.ImagesDice[i].TextDiceRoll.text = Model.RollResults[i].Result.ToString();
            }

            SubscriptionAggregator.ListenEvent(Model.ResultText, HandleResultTextChanged, true);
        }

        private void HandleResultTextChanged(object sender, GenericEventArg<string> e)
        {
            View.TextResult.text = e.Value;
        }
    }
}