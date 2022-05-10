using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class squirrel : MonoBehaviour
{
    // Start is called before the first frame update
    /*Rigidbody2D rb;
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

        
    }*/
    public float moveSpeed = 30f;
    private float xMin, xMax;
    private float yMin, yMax;
    public int shrooms=0;
    public Text textBox;
    public Sprite[] spriteArray;
  
    private int sp_index = 0;
    public SpriteRenderer spriteRenderer;
    private int vaal = 0;
    private void Start()
    {
        var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * .5f; 

        var cam = Camera.main;
        var camHeight = cam.orthographicSize;
        var camWidth = cam.orthographicSize * cam.aspect;

        yMin = -camHeight + spriteSize;
        yMax = camHeight - spriteSize; 

        xMin = -camWidth + spriteSize; 
        xMax = camWidth - spriteSize;  
    }

    private void Update()
    {
        // Get buttons
        var ver = Input.GetAxis("Vertical");
        var hor = Input.GetAxis("Horizontal");

        // Calculate movement direction
        var direction = new Vector2(hor, ver).normalized;
        direction *= moveSpeed * Time.deltaTime;

        var xValidPosition = Mathf.Clamp(transform.position.x + direction.x, xMin, xMax);
        var yValidPosition = Mathf.Clamp(transform.position.y + direction.y, yMin, yMax);

        transform.position = new Vector3(xValidPosition, yValidPosition, 0f);
        if ((ver!=0 || hor!=0)&&vaal % 100 == 0)
        {
            spriteRenderer.sprite = spriteArray[sp_index];
            if (sp_index == spriteArray.Length - 1)
            {
                sp_index = 0;
            }
            else
            {
                sp_index++;
            }

        }
        vaal++;

    }





    void OnTriggerEnter2D(Collider2D frog)
    
{
       
if (frog.name.Contains("shrooms"))
        { 
shrooms++;
        textBox.text = "Shrooms Collected: "+shrooms.ToString();


}

        if (frog.name.Contains("house"))
        {

            textBox.text = "You are home";
            Destroy(this.gameObject);
        }


    }
}
    

