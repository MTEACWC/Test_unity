using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int Speed { get; set; } = 10;
    void Update() => transform.Rotate(Vector3.up * Time.deltaTime * Speed);
}
