using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public Transform boardObject;
    // Start is called before the first frame update
    void Start()
    {
        for(float y=4;y>-4;y-=1f){
            for(float x=-4;x<4;x+=1f){
                Instantiate(boardObject, new Vector2(x, y), boardObject.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
