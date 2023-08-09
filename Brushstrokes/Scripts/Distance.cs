```csharp
using System;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public static float CalculateDistance(Vector3 point1, Vector3 point2)
    {
        return Vector3.Distance(point1, point2);
    }
}
```