using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public Transform WtokenObject;
    public Transform BtokenObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        if(gameflow.nowTurn == "W"){
            Instantiate(WtokenObject, transform.position, WtokenObject.rotation);
            gameflow.nowTurn = "B";
    }
        else if(gameflow.nowTurn == "B"){
            Instantiate(BtokenObject, transform.position, BtokenObject.rotation);
            gameflow.nowTurn = "W";
    }
    }
}
