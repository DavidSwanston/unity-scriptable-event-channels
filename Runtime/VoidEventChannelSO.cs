using UnityEngine;
using UnityEngine.Events;

namespace DavidSwanston.ScriptableEventChannels
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel", fileName = "VoidEventChannel")]
    public class VoidEventChannelSO : DescriptionSO
    {
        [Tooltip("The action to perform")]
        public UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            OnEventRaised?.Invoke();
        }
    }
}