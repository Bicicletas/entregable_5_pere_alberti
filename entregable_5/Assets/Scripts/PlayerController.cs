using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    private float verticalInput;
    public float turnSpeed = 20.0f;
    public float zMax = 450.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);
        
        if (transform.position.z > zMax)
        {
            Debug.Log($"THE END");
            Time.timeScale = 0;
        }
        
       
    }
}
