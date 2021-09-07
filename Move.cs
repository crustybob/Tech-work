using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
    
{
    public float maxPosition = 30;
    public float movementSpeed = 2;
    public Vector2 startPos;
    // Start is called before the first frame update
   
    void Start()
    {
        startPos = transform.position;
        Debug.Log("Start pos setup");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }

        if (gameObject.transform.position.x >= maxPosition)
        { 
        transform.position = startPos;
          
            Debug.Log("Now it will check to see if it's reached max distance");
        }
       
}   }
