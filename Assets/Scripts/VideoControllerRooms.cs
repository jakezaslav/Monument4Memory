using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControllerRooms : MonoBehaviour
{

    public GameObject video;

    void OnTriggerEnter(Collider collider)
    {
        video.SetActiveRecursively(true);

    }

    void OnTriggerExit(Collider collider)
    {
        video.SetActiveRecursively(false);
    }

}
