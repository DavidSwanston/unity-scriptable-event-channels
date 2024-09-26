using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a Transform payload.
    /// </summary>
    [CreateAssetMenu(fileName = "TransformEventChannel", menuName = "Events/Transform Event Channel", order = 5)]
    public class TransformEventChannelSO : GenericEventChannelSO<Transform>
    {
        
    }
}