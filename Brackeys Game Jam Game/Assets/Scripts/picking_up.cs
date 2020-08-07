using System.Security.Cryptography;
using UnityEngine;

public class picking_up : MonoBehaviour
{
    GameObject Grabbobject;
    public Transform grabpos;
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && (hit.transform.tag == "pickupable"))
        {
            Grabbobject = hit.transform.gameObject;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Grabbobject = null;
        }
        if (Grabbobject)
        {
            Grabbobject.GetComponent<Rigidbody>().velocity = 10 * (grabpos.position - Grabbobject.transform.position);
        }

    }
}
