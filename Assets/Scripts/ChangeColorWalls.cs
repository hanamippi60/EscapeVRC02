using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWalls : MonoBehaviour
{
    private GameObject obj;
    private Color objColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision){
        obj = collision.gameObject;
        objColor = obj.GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = objColor;
    }
}
