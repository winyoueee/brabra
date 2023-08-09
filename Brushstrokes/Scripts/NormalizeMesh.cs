```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalizeMesh : MonoBehaviour
{
    public static Vector3[] NormalizeVertices(Vector3[] vertices)
    {
        float[] magnitudes = new float[vertices.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            magnitudes[i] = vertices[i].magnitude;
        }

        Vector3[] normalizedVertices = new Vector3[vertices.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            normalizedVertices[i] = vertices[i] / magnitudes[i];
        }

        return normalizedVertices;
    }
}
```