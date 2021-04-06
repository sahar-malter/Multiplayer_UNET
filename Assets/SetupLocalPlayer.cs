using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    void Start()
    {
        if (isLocalPlayer)
        {
            gameObject.GetComponent<PlayerController>().enabled = true;
            gameObject.GetComponentInChildren<Camera>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponentInChildren<Camera>().enabled = false;
        }

    }
}