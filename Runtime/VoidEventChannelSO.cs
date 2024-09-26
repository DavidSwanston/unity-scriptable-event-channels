using UnityEngine;
using System;

namespace DavidSwanston.ScriptableEventChannels
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel", fileName = "VoidEventChannel", order = 8)]
    public class VoidEventChannelSO : DescriptionSO
    {
        [Tooltip("The action to perform")]
        public event Action OnEventRaised;

        public void RaiseEvent()
        {
            OnEventRaised?.Invoke();
        }
        
        public Delegate[] GetEventListeners()
        {
            return OnEventRaised?.GetInvocationList();
        }
    }
}