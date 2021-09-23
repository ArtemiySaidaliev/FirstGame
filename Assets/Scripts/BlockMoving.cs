using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float SpeedX;
    public float SpeedY;

    // Update is called once per frame
    void Update()
    {
        Vector3 V=gameObject.transform.position;
        V.x+=SpeedX;
        V.y+=SpeedY;
        gameObject.transform.position=V;
    }
}
