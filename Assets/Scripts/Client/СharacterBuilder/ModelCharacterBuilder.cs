using System.Collections.Generic;
using Client.СharacterBuilder.Steps;
using Reactivity;

namespace Client.СharacterBuilder
{
    public class ModelCharacterBuilder : IModelCharacterBuilder
    {
        private readonly ReactiveProperty<int> _currentStep = new(0);

        public ModelCharacterBuilder(List<IModelBuilderStep> steps)
        {
            Steps = steps;
        }

        public IReactiveProperty<int> CurrentStep => _currentStep;
        public List<IModelBuilderStep> Steps { get; }

        public void GoToPreviousStep()
        {
            if (_currentStep.Value > 0) _currentStep.Value--;
        }

        public void GoToNextStep()
        {
            if (_currentStep.Value < Steps.Count - 1) _currentStep.Value++;
        }
    }
}