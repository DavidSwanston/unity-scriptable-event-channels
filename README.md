
# ScriptableObject Event Channels
A scriptable object based event channel system for Unity.

This is heavily based on the examples in Unity's [Create modular game architecture in Unity with ScriptableObjects](https://unity.com/resources/create-modular-game-architecture-with-scriptable-objects-ebook?ungated=true&isGated=false) e-book.

I wanted to turn this into a package for easy use in new projects.

## Installation
Import using the unity package manager with this URL:
https://github.com/DavidSwanston/unity-scriptable-event-channels.git

## Usage
  Create a new event channel object (Right Click > Create > Events > xxx Event Channel)

  Create a broadcaster and a listener script:

#### Void Event Broadcaster Example
```csharp
    [SerializeField] private VoidEventChannelSO eventChannel;

    private void DoSomething()
    {
        // Do something here, then broadcast an event

        eventChannel?.RaiseEvent();
    }
```

#### Void Event Listener Example
```csharp
    [SerializeField] private VoidEventChannelSO eventChannel;

    private void OnEnable()
    {
        if (eventChannel != null)
            eventChannel.OnEventRaised += OnEventRaised;
    }

    private void OnDisable()
    {
        if (eventChannel != null)
            eventChannel.OnEventRaised -= OnEventRaised;
    }

    private void OnEventRaised()
    {
        // respond to the raised event
    }
```
Drag the VoidEventChannel object into both scripts in the inspector, and that's it!

![void-listeners](https://github.com/user-attachments/assets/d1ab2087-6466-4cc3-961f-1ac4546b7a83)

At runtime, a list of active listeners will be shown on the scriptable object. Clicking on a listener name will ping it in the hierarchy.

A test event can be sent to all listers with the Raise Test Event button.

## Extending

Events currently support the following types:
- Bool
- Float
- GameObject
- Int
- String
- Transform
- Vector2
- Vector3
- Void

To add another event type you need to create an empty script for it which inherits from GenericEventChannelSO and an empty custom inspector script for it which inherits from GenericEventChannelSOEditor.

Example:
```csharp
    [CreateAssetMenu(fileName = "FooEventChannel", menuName = "Events/Foo Event Channel")]
    public class FooEventChannelSO : GenericEventChannelSO<Foo>
    {   
    }
```

```csharp
    [CustomEditor(typeof(FooEventChannelSO))]
    public class FoolEventChannelSOEditor : GenericEventChannelSOEditor<Foo>
    {
    }
```

To create an  event with multiple parameters, you'd need to create another version of the GenericEventChannelSO script.