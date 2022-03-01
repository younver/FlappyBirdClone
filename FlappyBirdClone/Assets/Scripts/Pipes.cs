using System;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    public int lifetime;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
