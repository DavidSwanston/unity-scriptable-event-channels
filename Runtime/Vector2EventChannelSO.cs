using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a Vector2 payload.
    /// </summary>
    [CreateAssetMenu(fileName = "Vector2EventChannel", menuName = "Events/Vector2 Event Channel")]
    public class Vector2EventChannelSO : GenericEventChannelSO<Vector2>
    {
        
    }
}