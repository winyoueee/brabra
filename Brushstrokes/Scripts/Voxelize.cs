```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxelize : MonoBehaviour
{
    public static int[,,] VoxelizeMesh(Mesh mesh, int dim = 128)
    {
        int[,,] grid = new int[dim, dim, dim];

        foreach (Vector3 point in mesh.vertices)
        {
            int ix = Mathf.FloorToInt(point.x / dim);
            int iy = Mathf.FloorToInt(point.y / dim);
            int iz = Mathf.FloorToInt(point.z / dim);

            if (ix >= 0 && ix < dim && iy >= 0 && iy < dim && iz >= 0 && iz < dim)
            {
                grid[ix, iy, iz] = 1;
            }
        }

        return grid;
    }
}
```