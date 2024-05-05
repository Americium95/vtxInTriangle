public float vtxInTriangle(Vector2 point,Triangle triangle)
{
    float dis=((point-triangle.Vertices[0]).normalized+(point-triangle.Vertices[1]).normalized+(point-triangle.Vertices[2]).normalized).magnitude;
        
    return dis;
}
