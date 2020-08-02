using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    Camera MainCam;
    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        MainCam.transform.Rotate();

    }

    void LockOrUnlockCursor(CursorLocked)
    {
        if (CursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
