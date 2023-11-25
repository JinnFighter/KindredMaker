using Client.СharacterBuilder.Steps;
using Reactivity;

namespace Client.СharacterBuilder
{
    public class ControllerCharacterBuilder : BaseController<IModelCharacterBuilder, ViewCharacterBuilder>
    {
        protected override void InitInner()
        {
            SubscriptionAggregator.ListenEventExtended(Model.CurrentStep, HandleCurrentStepChanged, true);
        }

        protected override void RegisterChildControllers()
        {
            for (var i = 0; i < Model.Steps.Count; i++)
                RegisterChildController<ControllerBuilderStepAttributes>(Model.Steps[i], View.Steps[i]);
        }

        private void HandleCurrentStepChanged(object sender, PropertyEventArgs<int> e)
        {
            View.Steps[e.OldValue].gameObject.SetActive(false);
            View.Steps[e.NewValue].gameObject.SetActive(true);
        }
    }
}