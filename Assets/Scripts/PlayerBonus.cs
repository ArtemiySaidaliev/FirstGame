using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBonus : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerStats st;
    public float SpeedBonus;
    public float BonusSize;
    public float AddGrav;
     void Start () {
       
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            st.Speed=SpeedBonus;
            Vector3 V = collision.gameObject.transform.localScale;
            if (gameObject.tag == "Grow"){
            V.x *= BonusSize;
            V.y *= BonusSize;
            }



            if (gameObject.tag == "Gravity"){
               st.gravityscales=AddGrav;
            }





            if (gameObject.tag == "Small"){
            V.x /= BonusSize;
            V.y /= BonusSize;
            }
            collision.gameObject.transform.localScale = V;
            Destroy(gameObject);
        }
}
}
