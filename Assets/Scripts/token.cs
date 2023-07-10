using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class token : MonoBehaviour
{
    public string nowColor;

    // Start is called before the first frame update
    void Start()
    {
        nowColor = gameObject.tag;
        GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(activeDelay());

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "UL"){
            if((gameflow.ULChange == "Y") && (nowColor=="Black")){
                GetComponent<SpriteRenderer>().color = new Color(1,1,1);
                gameObject.tag = "White";

            }
             if((gameflow.ULChange == "Y") && (nowColor=="White")){
                GetComponent<SpriteRenderer>().color = new Color(0,0,0);
                gameObject.tag = "Black";

            }

              if((gameflow.ULChange == "R") && (nowColor=="Black")){
                // GetComponent<SpriteRenderer>().color = new Color(1,1,1);
                gameObject.tag = "Black";

            }
             if((gameflow.ULChange == "R") && (nowColor=="White")){
                // GetComponent<SpriteRenderer>().color = new Color(0,0,0);
                gameObject.tag = "White";

            }
        }

    }

    IEnumerator activeDelay(){
        yield return new WaitForSeconds(10);
        GetComponent<CircleCollider2D>().enabled = true;
    }

}
