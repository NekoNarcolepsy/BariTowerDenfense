using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{
    protected Camera cameraToLookAt;
    // Use this for initialization
    void Start()
    {
        cameraToLookAt = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }
    
    void Update()
    {

        transform.rotation = cameraToLookAt.transform.rotation;
    }

}