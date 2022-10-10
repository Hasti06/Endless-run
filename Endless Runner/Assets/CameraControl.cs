using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Create a public reference to the player - we will assign this using Unity editor 
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Change our position relative to the players postion
        

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
