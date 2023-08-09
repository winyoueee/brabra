```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBounds : MonoBehaviour
{
    public static float Distance(Vector3 point1, Vector3 point2)
    {
        return Vector3.Distance(point1, point2);
    }

    public static float GetBounds(Mesh mesh)
    {
        Vector3[] bounds = mesh.bounds;
        float boundsDistance = Distance(bounds[0], bounds[1]);
        Debug.Log("Bounds: " + boundsDistance);
        return boundsDistance;
    }
}
```