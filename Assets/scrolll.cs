using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolll : MonoBehaviour
{
  public float scrollSpeed=(float)20.0;

    private Renderer renderer;
    private Vector2 savedOffset;

    void Start () {
        renderer = GetComponent<Renderer> ();
    }

    void Update () {
	float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
	Vector2 offset = new Vector2 (x, 0);
    renderer.material.mainTextureOffset = offset;
    //Debug.Log("moved");
    }
}
