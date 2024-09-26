using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries an integer payload.
    /// </summary>
    [CreateAssetMenu(fileName = "IntEventChannel", menuName = "Events/Int Event Channel", order = 3)]
    public class IntEventChannelSO : GenericEventChannelSO<int>
    { 
        
    }
}
