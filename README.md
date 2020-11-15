# Scriptable-Events
Quickly setup static events with scriptable objects using the observer pattern. Custom events can also be created.

## How to install
This package can be installed through the Unity `Package Manager`

Open up the package manager `Window/Package Manager` and click on `Add package from git URL...`.

![unity_package_manager_git_drop_down](https://i.imgur.com/wRDQU8Z.png)

Paste in this repository's url.

`https://github.com/Jason-Skillman/Scriptable-Events.git`

![unity_package_manager_git_with_url](https://i.imgur.com/sNQYA13.png)

Click `Add` and the package will be installed in your project.

## How to use
You can create an event by going to `Create/Scriptable Events/<Event Type>` in the `Project` window. Each event is a scriptable prefab. Multible events can be created for your project and different event types exist. Some of the primitive event types include void, int, float, string and bool.

### Subscribing to an event
To subscribe to an event you can attach a method to the `OnTrigger` event in the scriptable object.

This is an example of a monobehavior script subscriping to `EventVoid`. Note: Dont forget to unsubscribe from the event when you no longer need to.

```C#
[SerializeField]
private EventVoid voidEvent;

private void OnEnable() {
	voidEvent.OnTrigger += SpawnBall;
}

private void OnDisable() {
	voidEvent.OnTrigger -= SpawnBall;
}

private void SpawnBall() {
	//Instantiate ball here...
}
```

Drag the scriptable object event into the `EventVoid` variable in the inspector and the game object will subscribe to the event when enabled/start.

```C#
[SerializeField]
private EventVoid voidEvent;
```

![scriptable_object_subscribing_event_inspector](https://i.imgur.com/wGfJZdb.png)

### Triggering an event
To trigger an existing event call the `Trigger()` method from the scriptable object. Every subscribed listener will get the fired event.

This is an example of a monobehavior who will trigger the `EventVoid` by calling `Trigger()` when the player enters it's trigger box.

```C#
[SerializeField]
private EventVoid voidEvent;

private void OnTriggerEnter(Collider other) {
    if(!other.CompareTag("Player")) return;

    voidEvent.Trigger();
}
```

## Creating custom events
If the existing primitive event types are not enough, custom event types can be written. Using the `UnityAction<>` delegate you specify different arguments and data.

Ex. Dictionary event with int as the key and string as the value `UnityAction<int, string>`.

Create a new script which extends `ScriptableObject` and follow a near similar format to the primitive types. Source code examples can be found in `ScriptableEvents/Runtime/Scripts/Events/PrimitiveTypes`.

### EventInt class example
|Property/Method|Description|
|---|---|
|`UnityAction<int>` `OnTrigger`|Event called when the scriptable event is triggered.|
|`Trigger()`|Main method to call to trigger the event.|

## Supported event types

### Primitive events
- void
- int
- float
- double
- long
- bool
- string

### Primitive array events
- int
- float
- double
- long
- bool
- string

### Unity events
- GameObject
- Scene
