using UnityEditor;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// Editor script to add a custom Inspector to the IntEventChannelSO. This uses a custom
    /// ListView to show all subscribed listeners.
    /// </summary>
    [CustomEditor(typeof(IntEventChannelSO))]
    public class IntEventChannelSOEditor : GenericEventChannelSOEditor<int>
    {
        
    }
    
}