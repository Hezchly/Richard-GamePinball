using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominController : MonoBehaviour
{
    public Collider Bola;
    public CameraController cameraController;
    public float length;

    private void OnTriggerEnter(Collider other)
    {
        if(other == Bola)
            cameraController.FollowTarget(Bola.transform, length);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
