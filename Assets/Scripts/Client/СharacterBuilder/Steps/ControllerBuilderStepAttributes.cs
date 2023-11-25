using System;
using System.Collections.Generic;
using Client.Common;
using Logic;

namespace Client.СharacterBuilder.Steps
{
    public class
        ControllerBuilderStepAttributes : BaseController<IModelBuilderStepAttributes, ViewBuilderStepAttributes>
    {
        private readonly List<IController> _subControllers = new();

        protected override void InitInner()
        {
            var i = 0;
            foreach (var obj in Enum.GetValues(typeof(EAttribute)))
            {
                var attribute = (EAttribute)obj;

                _subControllers.Add(
                    ControllerFactory.CreateController<ControllerRoundStat>(Model.Attributes[attribute],
                        View.Attributes[i]));
                i++;
                
                SubscriptionAggregator.ListenEvent(Model.Attributes[attribute].ValueChangeRequested, delegate(int arg0)
                {
                    HandleValueChangeRequested(attribute, arg0);
                });
            }

            for (var j = 1; j < 5; j++)
            {
                var idx = j - 1;
                SubscriptionAggregator.ListenEvent(Model.PointsDistribution[j],
                    (_, arg) => { View.ListDistributions[idx].text = $"x{arg.Value}"; }, true);
            }
        }

        private void HandleValueChangeRequested(EAttribute attribute, int value)
        {
            Model.TrySetNewAttributeValue(attribute, value);
        }

        protected override void TerminateInner()
        {
            foreach (var controller in _subControllers) controller.Terminate();

            _subControllers.Clear();
        }
    }
}