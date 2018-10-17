using UnityEngine;
using System

public class Rotate : MonoBehaviour
{
    public int Speed { get; set; } = 10;
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * Speed);
        transform.Rotate(Vector3.left * Time.deltaTime * Speed);
    }
}
