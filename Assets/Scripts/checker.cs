using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class checker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Empty"){
            gameflow.ULChange = "R";
            Destroy(gameObject);
        }

        if(other.tag == gameflow.nowTurn){
            gameflow.ULChange = "Y";
            Destroy(gameObject);
        }

        if(other.tag != gameflow.nowTurn){
            other.tag = gameObject.tag;
        }
    }
}
