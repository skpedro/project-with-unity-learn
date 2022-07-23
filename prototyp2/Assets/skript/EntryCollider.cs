using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryCollider : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Energy")) {
            PlayerInterface.hp++;
            Destroy(other.gameObject);
        }


        if (other.CompareTag("Animal")) {
            PlayerInterface.Damage();
        }
       
        if (other.CompareTag("Mark")){
            PlayerInterface.Point();          
            Destroy(other.gameObject);
           
        }
    }
}
