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
Vector2 centroid = polygon.centroid(polygon, out area);
var area = polygon.area();
var perimeter = polygon.perimeter();
var contains = polygon.contains(new Vector2(5, 5.5f));
```

Includes methods for probability.
```cs
IList<anyType> list = ...; // or you can use array

// fill list with some information

var combinationsOf3 = list.allNCombinations(3);

IList<float> floatList = ...;
//or
float[] floatList;
// fill list with some values
var mean = floatList.arithmeticMean();

```
