using UnityEngine;

namespace DavidSwanston.ScriptableEventChannels
{
    /// <summary>
    /// Base ScriptableObject with an added description field.
    /// </summary>
    public class DescriptionSO : ScriptableObject
    {
        [TextArea(5, 20)]
        [SerializeField] protected string description;
    }
}
