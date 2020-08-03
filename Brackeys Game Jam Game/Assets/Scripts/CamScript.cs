using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField]
    Camera MainCam;
    float MouseX, MouseY;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {    

        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y") * -1;
        transform.Rotate(new Vector3(0, MouseX, 0));
        MainCam.transform.Rotate(new Vector3(MouseY, 0, 0));

    }
}
