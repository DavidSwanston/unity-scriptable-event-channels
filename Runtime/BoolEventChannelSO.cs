using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a Boolean payload.
    /// </summary>
    [CreateAssetMenu(fileName = "BoolEventChannel", menuName = "Events/Bool Event Channel", order = 0)]
    public class BoolEventChannelSO : GenericEventChannelSO<bool>
    {
	 
    }
}
