using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySample : MonoBehaviour
{
   [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        Destroy(playerObject.GetComponent<PlayerController>());
    }
}
