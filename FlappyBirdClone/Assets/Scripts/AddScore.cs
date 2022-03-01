using System;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // If it triggers with something, add score
    private void OnTriggerEnter2D(Collider2D col)
    {
        Score.score += 1;
    }
}
