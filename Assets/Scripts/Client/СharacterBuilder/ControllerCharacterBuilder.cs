using System.Collections.Generic;
using Client.СharacterBuilder.Steps;
using Reactivity;

namespace Client.СharacterBuilder
{
    public class ControllerCharacterBuilder : BaseController<IModelCharacterBuilder, ViewCharacterBuilder>
    {
        private readonly List<IController> _subControllers = new();

        protected override void InitInner()
        {
            for (var i = 0; i < Model.Steps.Count; i++)
            {
                var controller =
                    ControllerFactory.CreateController<ControllerBuilderStepAttributes>(Model.Steps[i], View.Steps[i]);
                _subControllers.Add(controller);

                controller.Init();
            }

            SubscriptionAggregator.ListenEventExtended(Model.CurrentStep, HandleCurrentStepChanged, true);
        }

        protected override void TerminateInner()
        {
            foreach (var controller in _subControllers) controller.Terminate();

            _subControllers.Clear();
        }

        private void HandleCurrentStepChanged(object sender, PropertyEventArgs<int> e)
        {
            View.Steps[e.OldValue].gameObject.SetActive(false);
            View.Steps[e.NewValue].gameObject.SetActive(true);
        }
    }
}