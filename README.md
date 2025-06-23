# Attributes

* Property attributes for Unity fields
* Unity minimum version: **2020.3**
* Current version: **3.1.0**

## Summary

## How To Use

Just use one of the following attributes:

* **AssetsOnly**: only select assets references.
* **Required**: use it on strings, exposed and object reference types. If the value is null or empty, an error message will be displayed on Inspector bellow the given attribute.
* **Tag**: use it only with string fields. It'll replace the string field by a tag popup.
* **DisableInPlayMode**: use this to prevent users from editing a property when in play mode.

```csharp
using UnityEngine;
using ActionCode.Attributes;

public sealed class TestBehaviour : MonoBehaviour
{
    [AssetsOnly(typeof(GameObject))] public GameObject player;
    [Required] public string playerId;
    [Tag] public string playerTag = "Player";
}
```

![Attributes](/Documentation~/attributes-simple.gif)

* **ShowIf**: use it to show properties based on the current state of the object.

```csharp
using ActionCode.Attributes;

public sealed class TestBehaviour : MonoBehaviour
{
    [Range(0, 20)] public int powerLevel;
    [ShowIf(nameof(powerLevel), LogicalOperatorType.GreaterOrEqual, 10)]
    public string powerLevelName = "Super Power";
}
```

![Show If Attribute Showcase](/Documentation~/attributes-show-if.gif)

* **Readonly**: use it to disable changes in properties.
* **ReadonlyIf**: use it to not allow changes in properties based on the current state of the object.

```csharp
using ActionCode.Attributes;

public sealed class TestBehaviour : MonoBehaviour
{
    public RigidbodyConstraints2D constraint;
    [ReadonlyIf(nameof(constraint), RigidbodyConstraints2D.FreezePositionX)]
    public float forceX = 10F;
}
```

![Readonly If Attribute Showcase](/Documentation~/attributes-readonly-if.gif)

* **CreateButton**: use it to add a Create Button next to a ScriptableObject field if no reference is set.

```csharp
using ActionCode.Attributes;

public sealed class TestBehaviour : MonoBehaviour
{
    [CreateButton(typeof(SceneTransition))]
    public SceneTransition defaultTransition;
}
```

![Create Button Attribute Showcase](/Documentation~/attributes-create-button.png)