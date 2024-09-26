using UnityEditor;
using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// Editor script to add a custom Inspector to the TransformEventChannelSO. This uses a custom
    /// ListView to show all subscribed listeners.
    /// </summary>
    [CustomEditor(typeof(TransformEventChannelSO))]
    public class TransformEventChannelSOEditor : GenericEventChannelSOEditor<Transform>
    {
        
    }
}