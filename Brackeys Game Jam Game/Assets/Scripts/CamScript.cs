using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField]
    Camera MainCam;
    float MouseX, MouseY;
    bool EscapeMenu;
    Player_Move movescript;
    bool unlockdone;
    [SerializeField]
    Canvas pausemenu;
    bool lockedcursor;
    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
        movescript = GetComponent<Player_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) pausemenu.gameObject.SetActive(true);

        if (pausemenu.gameObject.activeSelf)
        {
            movescript.Movelock(true);
            Cursor.lockState = CursorLockMode.None;
            return;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            movescript.Movelock(false);
            pausemenu.gameObject.SetActive(false);
        }
        
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y") * -1;
        transform.Rotate(new Vector3(0, MouseX, 0));
        MainCam.transform.Rotate(new Vector3(MouseY, 0, 0));

    }
}
