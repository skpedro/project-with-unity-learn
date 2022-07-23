using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerInterface : MonoBehaviour
    {
        private static int point;
        public static int hp = 10;

         private void Start()
         {
            Debug.Log("Hp" + hp);
         }
         public void Update()
         {
             if (hp <= 0)
             {
               Destroy(gameObject);
             }
           
         }
        
         public static void Point()
         {
            point++;
            Debug.Log("Point" + point);
         }
         public static void Damage()
         {
            hp--;
            if (hp <= 0) {
                Debug.Log("you died");
            }
            else {
            Debug.Log("Hp" + hp);
            }
            
         }

    }



