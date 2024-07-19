using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float chargePower = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            chargePower += Time.deltaTime;
            GameObject heldBall = GameObject.FindGameObjectWithTag("HeldBall");
            if (heldBall.GetComponent<SpriteRenderer>().enabled == false){
                heldBall.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            GetComponent<PlayerThrowing>().Throw(chargePower);
            chargePower = 1;
        }
    }
}
