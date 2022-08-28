using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateCubes : MonoBehaviour
{
    public Vector2 spawnerPos; 
    public GameObject[] cubes = new GameObject[64];
    public GameObject cubesPrefab;

    public float maxScale; 
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 64; i++)
        {
            GameObject instanceCubes = (GameObject)Instantiate(cubesPrefab);
            instanceCubes.transform.position = this.transform.position;
            instanceCubes.transform.parent = this.transform;
            instanceCubes.name = "SampleCube" + i;
            instanceCubes.transform.position = spawnerPos + Vector2.right * (i * 2);
            cubes[i] = instanceCubes; 
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i = 0; i < 64; i++)
        {
            if(cubes != null)
            {
                cubes[i].transform.localScale = new Vector2(10, (AudioVisualizer.samples[i] * maxScale) + 2); 
            }
        }
    }
}
