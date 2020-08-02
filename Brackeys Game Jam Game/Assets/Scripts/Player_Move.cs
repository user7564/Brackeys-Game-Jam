using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.GetAxis("Vertical") * speed * Time.deltaTime * transform.forward + Input.GetAxis("Horizontal") * speed * Time.deltaTime * transform.right);
    }
}
