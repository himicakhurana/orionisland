using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirrel : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpforce = 10f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             this.transform.Translate(Vector3.right * Time.deltaTime);
        } 
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce);
            Debug.Log("jump");
        }
        
    }
}
