```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static float MapValue(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return outMin + ((value - inMin) / (inMax - inMin)) * (outMax - outMin);
    }
}
```