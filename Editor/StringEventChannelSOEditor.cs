using UnityEditor;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// Editor script to add a custom Inspector to the StringEventChannelSO. This uses a custom
    /// ListView to show all subscribed listeners.
    /// </summary>
    [CustomEditor(typeof(StringEventChannelSO))]
    public class StringEventChannelSOEditor : GenericEventChannelSOEditor<string>
    {
        
    }
}