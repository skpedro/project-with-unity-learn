using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeControl : MonoBehaviour
{
    float HorizontalInput;
    float VerticalInput;
    public float speedHorizontal=20;
    public float speedForward=10;
    private int Rang = 11;
    private int rangeForward=12;
    private int rangeBehide = -2;
    public GameObject food;

    
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speedHorizontal);
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speedForward);
        //отслеживание выход за пределы 
        Range(); 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food,transform.position,food.transform.rotation);
        }
    }

    private void Range()
    {
        if (transform.position.x < -Rang)
        {
            transform.position = new Vector3(-11, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Rang)
        {
            transform.position = new Vector3(11, transform.position.y, transform.position.z);
        }

        if (transform.position.z > rangeForward)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeForward);
        }
        if (transform.position.z < rangeBehide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeBehide);
        }
    }
}
