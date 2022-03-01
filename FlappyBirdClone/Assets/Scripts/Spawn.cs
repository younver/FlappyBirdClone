using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float height;
    
    public float delay;
    private float timer;
    
    public GameObject pipes;

    private void Update()
    {
        // timer-delay mechanic
        if (timer > delay)
        {
            // spawn
            GameObject newPipes = Instantiate(pipes);
            newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            
            // reset
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
