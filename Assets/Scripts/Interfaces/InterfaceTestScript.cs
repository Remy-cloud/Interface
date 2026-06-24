using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Trapezium tra = new Trapezium();
        tra.CalculateArea();
        tra.CalculatePerimeter();
        tra.CalculateUnknownSides();

        Circle cir = new Circle();
        cir.CalculateArea();
        cir.CalculatePerimeter();
        cir.CalculateRadius();

        Nonagon non = new Nonagon();
        non.CalculateArea();
        non.CalculatePerimeter();
        Debug.Log("Nonagon Number of Sides: " + non.CalculateNumberOfSides());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    float a = 8f, b = 14f, c = 5f, d = 6f, height = 4f;

    public void CalculateUnknownSides()
    {
        float unknown = Mathf.Sqrt((b - a) * (b - a) + height * height);
        Debug.Log("Trapezium Unknown Side = " + unknown);
    }

    public void CalculateArea()
    {
        float area = 0.5f * (a + b) * height;
        Debug.Log("Trapezium Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = a + b + c + d;
        Debug.Log("Trapezium Perimeter = " + perimeter);
    }
}

public class Circle : IShape
{
    float radius = 5f;

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle Area = " + area);
    }

    public void CalculateRadius()
    {
        Debug.Log("Circle Radius = " + radius);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle Perimeter = " + perimeter);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;
    float sideLength = 5f;

    public void CalculateArea()
    {
        float area = (numberOfSides * sideLength * sideLength) / (4 * Mathf.Tan(Mathf.PI / numberOfSides));
        Debug.Log("Nonagon Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon Perimeter = " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
