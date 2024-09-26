using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a string payload.
    /// </summary>
    [CreateAssetMenu(fileName = "StringEventChannel", menuName = "Events/String Event Channel", order = 4)]
    public class StringEventChannelSO : GenericEventChannelSO<string>
    {
        
    }
}