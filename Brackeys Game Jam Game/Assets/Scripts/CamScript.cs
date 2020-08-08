using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CamScript : MonoBehaviour
{
    [SerializeField]
    Camera MainCam;
    float MouseX, MouseY;
    [SerializeField]
    GameObject[] SpawnableObjects;
    [SerializeField]
    int ChosenObject;
    [SerializeField]
    float maxplacelength;
    [SerializeField]
    TMP_Text Selectedobj;
    [SerializeField]
    TMP_Text Tutorial;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
        StartCoroutine(TextChange());
    }

    // Update is called once per frame
    void Update()
    {    

        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y") * -1;
        transform.Rotate(new Vector3(0, MouseX, 0));
        MainCam.transform.Rotate(new Vector3(MouseY, 0, 0));
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            ChosenObject += 1;
            StartCoroutine(TextChange());
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            ChosenObject -= 1;
            StartCoroutine(TextChange());
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if(Physics.Raycast(MainCam.transform.position, MainCam.transform.forward, out RaycastHit Hit, maxplacelength))
            {
                GameObject.Instantiate(SpawnableObjects[ChosenObject], Hit.point + (Hit.normal*.5f), Quaternion.FromToRotation(Vector3.up, Hit.normal));
            }
            
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Tutorial.gameObject.SetActive(!Tutorial.gameObject.activeSelf);
        }
    }
    IEnumerator TextChange()
    {
        ChosenObject = Mathf.Clamp(ChosenObject, 0, SpawnableObjects.Length-1);
        Selectedobj.gameObject.SetActive(true);
        Selectedobj.text = "Selected Object: " + SpawnableObjects[ChosenObject].name;
        yield return new WaitForSeconds(5);
        Selectedobj.gameObject.SetActive(false);
    }
}
