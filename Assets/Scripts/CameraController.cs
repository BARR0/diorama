using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // [SerializedField] Transform camera;
    public Transform camera;
    public Transform cube;

    // Start is called before the first frame update
    void Start()
    {
        // camera.x;
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = Vector3.MoveTowards(camera.position, cube.position, Time.deltaTime);
    }
}
