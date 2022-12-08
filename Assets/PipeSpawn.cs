using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public float heightOffSet;
    public GameObject pipes;
    // Start is called before the first frame update
    void Start(){
        GameObject freshPipe = Instantiate(pipes);
        freshPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heightOffSet, heightOffSet), 0);
    }

    // Update is called once per frame
    void Update(){
        if(timer > maxTime)
        {
            GameObject freshPipe = Instantiate(pipes);
            freshPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heightOffSet, heightOffSet), 0);
            Destroy(freshPipe, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
