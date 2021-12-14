using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToCamera : MonoBehaviour
{
    void Update()
    {
        // Change rotation of attached object in camera direction
        this.gameObject.transform.rotation = Camera.main.transform.rotation;
    }
}
