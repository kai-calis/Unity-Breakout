using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject wall_door;
    
    void OnTriggerEnter(Collider col)
    {
        wall_door.transform.position += new Vector3(0,8,0);
        
    }

}
