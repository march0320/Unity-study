using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner1 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabArray;

    private void Awake()
    {
        for(int i=0; i<10; ++i)
        {
            int index=1;
            Vector3 position=new Vector3(-4.5f+i,0,0);
            Instantiate(prefabArray[index],position,Quaternion.identity);
        }
    }
}
