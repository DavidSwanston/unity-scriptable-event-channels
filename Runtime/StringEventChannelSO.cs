using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a string payload.
    /// </summary>
    [CreateAssetMenu(fileName = "StringEventChannel", menuName = "Events/String Event Channel")]
    public class StringEventChannelSO : GenericEventChannelSO<string>
    {
        
    }
}