using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPromtUI : MonoBehaviour
{
    private Camera _mainCamera;
    void Start()
    {
        _mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        var rotation = _mainCamera.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }

}
