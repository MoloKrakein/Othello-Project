using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public Transform WtokenObject;
    public Transform BtokenObject;

    public Transform CheckerObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameflow.nowTurn == "W")
        {
            Instantiate(WtokenObject, transform.position, WtokenObject.rotation);
            // gameflow.nowTurn = "B";
            StartCoroutine(waittochangeB());
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(CheckerObject, transform.position, CheckerObject.rotation);
        }
        else if (gameflow.nowTurn == "B")
        {
            Instantiate(BtokenObject, transform.position, BtokenObject.rotation);
            // gameflow.nowTurn = "W";
            StartCoroutine(waittochangeW());
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(CheckerObject, transform.position, CheckerObject.rotation);
        }
    }

    IEnumerator waittochangeB(){
        yield return new WaitForSeconds(3);
        gameflow.nowTurn = "B";
        gameflow.ULChange = "N";
    }
        IEnumerator waittochangeW(){
        yield return new WaitForSeconds(3);
        gameflow.nowTurn = "W";
        gameflow.ULChange = "N";
    }
}
