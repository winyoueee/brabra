Shared Dependencies:

1. Function Names: The following function names are shared across multiple files: `distance`, `map`, `normalizeMesh`, `loadMesh`, `getBounds`, `dbscanLines`, `voxelize`, `group_points_into_strokes`.

2. Variables: The following variables are shared across multiple files: `point1`, `point2`, `value`, `inMin`, `inMax`, `outMin`, `outMax`, `vertices`, `inputUrl`, `mesh`, `points`, `eps`, `min_samples`, `dim`, `argv`, `inputPath`, `la`, `ms`, `bounds`, `samplePercentage`, `searchRadius`, `minPointsCount`, `newSampleNum`, `radius`, `strokes`, `unassigned_points`, `stroke`, `i`, `la_stroke`, `index`, `vert`, `la_point`.

3. Libraries: The following libraries are shared across multiple files: `trimesh`, `pymeshlab`, `numpy`, `latk`, `scipy.spatial.distance`, `sklearn.cluster`, `scipy.interpolate`, `sys`.

4. Data Schemas: The data schemas for the mesh and point data structures are shared across multiple files.

5. Message Names: The following message names are shared across multiple files: "Found mesh with " + str(len(mesh.faces)) + " faces.", "Meshing pointcloud with 0 faces.", "Bounds: " + str(bounds), "Search radius: " + str(searchRadius) + ", Min points per stroke: " + str(minPointsCount), "Found " + str(len(strokes)) + " strokes, " + str(len(unassigned_points)) + " points remaining.", "No strokes generated."

6. File Names: The following file names are shared across multiple files: "temp.ply", "output.latk".