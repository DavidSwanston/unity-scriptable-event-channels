using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a Vector3 payload.
    /// </summary>
    [CreateAssetMenu(fileName = "Vector3EventChannel", menuName = "Events/Vector3 Event Channel")]
    public class Vector3EventChannelSO : GenericEventChannelSO<Vector3>
    {
        
    }
}