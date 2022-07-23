using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hungre : MonoBehaviour
{
    private float hungry;
    public float damage;  
    public float Maxhungry=1;
    public Slider slider;

    void Start()
    {       
        hungry = 0;
        slider.value = 0;
    }

    void Update()
    {
        slider.value = hungry;
        
        if (hungry>=Maxhungry)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mark"))
        {       
            Calculat();      
        }
    }
    public void Calculat()
    {
        hungry = hungry + damage;
    }
}
