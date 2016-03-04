# Math-net
.Net package for Probability and Geometric operations.

A math libary for geometric and probability operations.

Includes structs Vector2, Vector3 that supports basic vector oprations;
```cs
var v1 = new Vector2(4.5f, 5.8f);
var v2 = new Vector2(2f, -8f);
var v3 = v1 + v2;
var v4 = v3 * 3.5f;

```
Includes some tests and methods for polygon;

```cs
var polygon = new Vector2[] { new Vector2(3, 4), new Vector2(6, 8.5f), new Vector2(8.2f, 4f), new Vector2(5.6f, -0.4f) };
// or
var polygon = new List<Vector2>();
polygon.Add(new Vector2(3, 4));
polygon.Add(new Vector2(6, 8.5f));
polygon.Add(new Vector2(8.2f, 4f));
polygon.Add(new Vector2(5.6f, -0.4f));


float area;
Vector2 centroid = Geometry.centroid(polygon, out area);
```
