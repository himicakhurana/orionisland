using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    // Start is called before the first frame update
      public Camera MainCamera;
     private Rect screenBounds;
    void Start()
    {
        MainCamera=Camera.main;
        float cameraHeight = MainCamera.orthographicSize * 2;
         float cameraWidth = cameraHeight * MainCamera.aspect;
         Vector2 cameraSize = new Vector2(cameraWidth, cameraHeight);
         Vector2 cameraCenterPosition = MainCamera.transform.position;
         Vector2 cameraBottomLeftPosition = cameraCenterPosition - (cameraSize / 2);
         screenBounds = new Rect(cameraBottomLeftPosition , cameraSize);
         Debug.Log(cameraHeight);
         Debug.Log(cameraWidth);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime);
        }    
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             this.transform.Translate(Vector3.right * Time.deltaTime);
        } 
        screenBounds.position = (Vector2)MainCamera.transform.position + (screenBounds.size / 4);
    }

    void LateUpdate()
    {
            screenBounds.position = (Vector2)MainCamera.transform.position + (screenBounds.size / 4);
    }
}
