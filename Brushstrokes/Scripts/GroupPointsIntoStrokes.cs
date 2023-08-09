```csharp
using System;
using System.Collections.Generic;
using UnityEngine;

public class GroupPointsIntoStrokes : MonoBehaviour
{
    public List<List<Vector3>> GroupPointsIntoStrokes(List<Vector3> points, float radius)
    {
        List<List<Vector3>> strokes = new List<List<Vector3>>();
        List<int> unassignedPoints = new List<int>();
        for (int i = 0; i < points.Count; i++)
        {
            unassignedPoints.Add(i);
        }

        while (unassignedPoints.Count > 0)
        {
            List<Vector3> stroke = new List<Vector3>();
            stroke.Add(points[unassignedPoints[0]]);
            unassignedPoints.RemoveAt(0);

            for (int i = 0; i < points.Count; i++)
            {
                if (unassignedPoints.Contains(i) && Vector3.Distance(points[i], points[stroke[stroke.Count - 1]]) < radius)
                {
                    stroke.Add(points[i]);
                    unassignedPoints.Remove(i);
                }
            }

            if (stroke.Count >= 5)
            {
                strokes.Add(stroke);
                Debug.Log("Found " + strokes.Count + " strokes, " + unassignedPoints.Count + " points remaining.");
            }
        }

        return strokes;
    }
}
```