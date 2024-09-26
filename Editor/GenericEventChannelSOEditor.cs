using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace DavidSwanston.ScriptableEventChannels.Editor
{
    /// <summary>
    /// This Editor class creates a custom Inspector for event channels that carry a payload
    /// (e.g., BoolEventChannelSO, FloatEventChannelSO, etc.). A ListView shows the subscribed
    /// listeners in the scene. Click each item to ping it in the Hierarchy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [CustomEditor(typeof(GenericEventChannelSO<>), true)]
    public abstract class GenericEventChannelSOEditor<T> : UnityEditor.Editor
    {
        private GenericEventChannelSO<T> _eventChannel;

        // Label and counter for items in the list
        private Label _listenersLabel;
        private ListView _listenersListView;
        private Button _raiseEventButton;
        private T _testEventData;

        private void OnEnable()
        {
            if (_eventChannel == null)
                _eventChannel = target as GenericEventChannelSO<T>;
        }

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            
            // Draw default elements in the inspector
            // InspectorElement.FillDefaultInspector(root, serializedObject, this);
            
            var scriptField = new PropertyField(serializedObject.FindProperty("m_Script"), "Script");
            scriptField.SetEnabled(false);
            root.Add(scriptField);
            
            var descriptionField = new PropertyField(serializedObject.FindProperty("description"), "Description");
            root.Add(descriptionField);

            var spaceElement = new VisualElement
            {
                style =
                {
                    marginBottom = 20
                }
            };
            root.Add(spaceElement);

            // Add a label
            _listenersLabel = new Label
            {
                text = "Listeners:",
                style =
                {
                    borderBottomWidth = 1,
                    borderBottomColor = Color.grey,
                    marginBottom = 2
                }
            };
            root.Add(_listenersLabel);

            // Add a ListView to show Listeners
            _listenersListView = new ListView(GetListeners(), 20, MakeItem, BindItem);
            root.Add(_listenersListView);
            
            // Button to test event
            _raiseEventButton = new Button
            {
                text = "Raise Test Event"
            };
            
            _raiseEventButton.RegisterCallback<ClickEvent>(evt => _eventChannel.RaiseEvent(_eventChannel.testEventValue));
            _raiseEventButton.style.marginBottom = 20;
            _raiseEventButton.style.marginTop = 20;
            root.Add(_raiseEventButton);
            
            var testValueField = new PropertyField(serializedObject.FindProperty("testEventValue"), "Test Event Value");
            root.Add(testValueField);
            
            return root;
        }

        private VisualElement MakeItem()
        {
            var element = new VisualElement();
            var label = new Label();
            element.Add(label);
            return element;
        }

        private void BindItem(VisualElement element, int index)
        {
            //if (m_RuntimeSet.Items.Count == 0)
            //    return;
            List<MonoBehaviour> listeners = GetListeners();

            var item = listeners[index];

            Label label = (Label)element.ElementAt(0);
            label.text = GetListenerName(item);

            // Attach a ClickEvent to the label
            label.RegisterCallback<MouseDownEvent>(evt =>
            {
                // Ping the item in the Hierarchy
                EditorGUIUtility.PingObject(item.gameObject);
            });

        }

        private string GetListenerName(MonoBehaviour listener)
        {
            if (listener == null)
                return "<null>";

            string combinedName = listener.gameObject.name + " (" + listener.GetType().Name + ")";
            return combinedName;

        }

        // Gets a list of MonoBehaviours that are listening to the event channel
        private List<MonoBehaviour> GetListeners()
        {
            List<MonoBehaviour> listeners = new List<MonoBehaviour>();

            if (_eventChannel == null || _eventChannel.GetEventListeners() == null)
                return listeners;

            // Get all delegates subscribed to the OnEventRaised action
            var delegateSubscribers = _eventChannel.GetEventListeners();

            foreach (var subscriber in delegateSubscribers)
            {
                // Get the MonoBehaviour associated with each delegate
                var componentListener = subscriber.Target as MonoBehaviour;

                // Append to the list and return
                if (!listeners.Contains(componentListener))
                {
                    listeners.Add(componentListener);
                }
            }

            return listeners;
        }

    }
}

// To create additional custom Inspectors for your event channels, simply derive the 
// corresponding Editor classes from GenericEventChannelSOEditor<T> filling in the
// appropriate type T. Add the CustomEditor Attribute with the concrete class type.

// To use this, the event channel must derive from GenericEventChannelSO<T>.

// For example to create the custom Inspector for FloatEventChannelSO:

//[CustomEditor(typeof(FloatEventChannelSO))]
//public class FloatEventChannelSOEditor : GenericEventChannelSOEditor<float>
//{

//}

// Leave the implementation blank unless it requires extra customization.
