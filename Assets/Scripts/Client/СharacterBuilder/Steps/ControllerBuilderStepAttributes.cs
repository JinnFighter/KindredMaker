using System;
using Client.Common;
using Logic;

namespace Client.СharacterBuilder.Steps
{
    public class
        ControllerBuilderStepAttributes : BaseController<IModelBuilderStepAttributes, ViewBuilderStepAttributes>
    {
        protected override void InitInner()
        {
            foreach (var obj in Enum.GetValues(typeof(EAttribute)))
            {
                var attribute = (EAttribute) obj;

                SubscriptionAggregator.ListenEvent(Model.Attributes[attribute].ValueChangeRequested,
                    delegate(int arg0) { HandleValueChangeRequested(attribute, arg0); });
            }

            for (var j = 1; j < 5; j++)
            {
                var idx = j - 1;
                SubscriptionAggregator.ListenEvent(Model.PointsDistribution[j],
                    (_, arg) => { View.ListDistributions[idx].text = $"x{arg.Value}"; }, true);
            }
        }

        protected override void RegisterChildControllers()
        {
            var i = 0;
            foreach (var obj in Enum.GetValues(typeof(EAttribute)))
            {
                var attribute = (EAttribute) obj;

                RegisterChildController<ControllerRoundStat>(Model.Attributes[attribute],
                    View.Attributes[i]);
                i++;
            }
        }

        private void HandleValueChangeRequested(EAttribute attribute, int value)
        {
            Model.TrySetNewAttributeValue(attribute, value);
        }
    }
}