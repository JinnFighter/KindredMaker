using Reactivity;
using UnityEngine.Events;

namespace Client.Common
{
    public class ModelRoundStat : IModelRoundStat
    {
        private readonly ReactiveProperty<int> _amount;

        public ModelRoundStat(string name, int amount = 0)
        {
            Name = new ReactiveProperty<string>(name);
            _amount = new ReactiveProperty<int>(amount);
        }

        public IReactiveProperty<string> Name { get; }
        public IReactiveProperty<int> Amount => _amount;

        public void SetAmount(int amount)
        {
            _amount.Value = amount;
        }

        public void RequestChange(int amount)
        {
            ValueChangeRequested.Invoke(amount);
        }

        public UnityEvent<int> ValueChangeRequested { get; } = new();
    }
}