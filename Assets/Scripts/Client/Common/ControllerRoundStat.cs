using Reactivity;

namespace Client.Common
{
    public class ControllerRoundStat : BaseController<IModelRoundStat, ViewRoundStat>
    {
        protected override void InitInner()
        {
            SubscriptionAggregator.ListenEvent(Model.Name, HandleNameChanged, true);
            SubscriptionAggregator.ListenEvent(Model.Amount, HandleAmountChanged, true);

            var i = 0;
            foreach (var slot in View.Slots)
                SubscriptionAggregator.ListenEvent(slot.onValueChanged, delegate
                {
                    Model.RequestChange(i);
                });
        }

        private void HandleNameChanged(object sender, GenericEventArg<string> e)
        {
            View.TextName.text = e.Value;
        }

        private void HandleAmountChanged(object sender, GenericEventArg<int> e)
        {
            for (var i = 0; i < View.Slots.Count; i++) View.Slots[i].SetIsOnWithoutNotify(i < e.Value);
        }
    }
}