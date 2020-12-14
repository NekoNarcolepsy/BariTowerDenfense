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
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(cameraToLookAt.transform.position - v);
    }

}