using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour {

    public TextMesh Name;
    public GameObject redHp;
    [HideInInspector]
    public Camera mainCamera;

    public float offsetScale = 0.02f;
    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.localScale = Vector3.Distance(transform.position, mainCamera.transform.position) * Mathf.Tan(20) * Vector3.one * offsetScale;
    }

}
