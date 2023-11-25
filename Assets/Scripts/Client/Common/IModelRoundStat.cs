using Reactivity;
using UnityEngine.Events;

namespace Client.Common
{
    public interface IModelRoundStat : IModel
    {
        IReactiveProperty<string> Name { get; }
        IReactiveProperty<int> Amount { get; }

        UnityEvent<int> ValueChangeRequested { get; }
        void SetAmount(int amount);

        void RequestChange(int amount);
    }
}