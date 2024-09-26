using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// General Event Channel that broadcasts and carries a GameObject payload.
    /// </summary>
    [CreateAssetMenu(fileName = "GameObjectEventChannel", menuName = "Events/GameObject Event Channel", order = 2)]
    public class GameObjectEventChannelSO : GenericEventChannelSO<GameObject>
    {

    }
}