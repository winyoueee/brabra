```csharp
using System.Collections.Generic;
using UnityEngine;
using Accord.MachineLearning;

public class DBSCANLines : MonoBehaviour
{
    public static List<Vector3[]> DBSCAN(Vector3[] points, float eps = 0.1f, int min_samples = 5)
    {
        var returns = new List<Vector3[]>();
        var dbscan = new DBSCAN<Vector3>(eps, min_samples, Distance);
        var clusters = dbscan.Learn(points);

        foreach (var cluster in clusters.Clusters)
        {
            if (cluster.Count == 0) continue;

            var cluster_points = new Vector3[cluster.Count];
            for (int i = 0; i < cluster.Count; i++)
            {
                cluster_points[i] = points[cluster[i]];
            }

            var tck = Spline.CubicSpline.InterpolateNatural(cluster_points);
            var new_points = new Vector3[100];
            for (int i = 0; i < 100; i++)
            {
                new_points[i] = tck.Interpolate(i / 100f);
            }

            returns.Add(new_points);
        }

        return returns;
    }

    private static double Distance(Vector3 a, Vector3 b)
    {
        return Vector3.Distance(a, b);
    }
}
```
This C# code uses the Accord.NET Framework for the DBSCAN algorithm and cubic spline interpolation. The `DBSCAN` function takes an array of 3D points, an epsilon value, and a minimum samples value as input, and returns a list of point arrays representing the clusters found by the DBSCAN algorithm. Each cluster is interpolated into a smooth curve using cubic spline interpolation. The `Distance` function is used by the DBSCAN algorithm to calculate the distance between points.