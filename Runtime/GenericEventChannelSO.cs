using System;

namespace DavidSwanston.ScriptableEventChannels
{
    public abstract class GenericEventChannelSO<T> : DescriptionSO
    {
        public event Action<T> OnEventRaised;

        public T testEventValue = default;

        public void RaiseEvent(T parameter)
        {
            OnEventRaised?.Invoke(parameter);
        }

        public Delegate[] GetEventListeners()
        {
            return OnEventRaised?.GetInvocationList();
        }
    }

    // To create addition event channels, simply derive a class from GenericEventChannelSO
    // filling in the type T. Leave the concrete implementation blank. This is a quick way
    // to create new event channels.

    // For example:
    //[CreateAssetMenu(menuName = "Events/Float EventChannel", fileName = "FloatEventChannel")]
    //public class FloatEventChannelSO : GenericEventChannelSO<float> {}

    // Define additional GenericEventChannels if you need more than one parameter in the payload.
}