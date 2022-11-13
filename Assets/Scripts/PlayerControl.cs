using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10.0f;
    private float range = 8.0f;
    public GameObject projectileMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileMove, transform.position, projectileMove.transform.rotation);
        }
        
    }
}
