using UnityEditor;
using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// Editor script to add a custom Inspector to the GameObjectEventChannelSO. This uses a custom
    /// ListView to show all subscribed listeners.
    /// </summary>
    [CustomEditor(typeof(GameObjectEventChannelSO))]
    public class GameObjectEventChannelSOEditor : GenericEventChannelSOEditor<GameObject>
    {
        
    }
}