using UnityEditor;
using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// Editor script to add a custom Inspector to the Vector3EventChannelSO. This uses a custom
    /// ListView to show all subscribed listeners.
    /// </summary> 
    [CustomEditor(typeof(Vector3EventChannelSO))]
    public class Vector3EventChannelSOEditor : GenericEventChannelSOEditor<Vector3>
    {
    }
}