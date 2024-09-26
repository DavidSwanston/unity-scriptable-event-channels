using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a Float payload.
    /// </summary>
    [CreateAssetMenu(fileName = "FloatEventChannel", menuName = "Events/Float Event Channel", order = 1)]
    public class FloatEventChannelSO : GenericEventChannelSO<float>
    {
        
    }
}