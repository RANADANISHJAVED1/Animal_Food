using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneAnimalMove : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float invokedelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createAnimal",2, invokedelay );
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void createAnimal()
    {
        int animalnumber = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[animalnumber], new Vector3(Random.Range(-8, 8), 0, 20), animalsPrefabs[animalnumber].transform.rotation);
    }
}
