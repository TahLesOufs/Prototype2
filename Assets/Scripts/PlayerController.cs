using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    private float horizontalInput;
    private float speed = 22f;
    private float Xrange = 20;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
       
        }
        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }
            horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
