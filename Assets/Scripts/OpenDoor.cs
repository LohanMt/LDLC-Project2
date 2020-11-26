using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    //Lorsqu'il y a collision
    private void OnTriggerStay(Collider other)
    {
        door.SetActive(false);
    }

    //Appelé à  la frmae où il n'y a plus collision
    private void OnTriggerExit(Collider other)
    {
        door.SetActive(true);
    }
}
