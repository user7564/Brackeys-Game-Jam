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
    void FixedUpdate()
    {
        rb.velocity = Input.GetAxis("Horizontal") * speed * transform.right + new Vector3(0, rb.velocity.y, 0) + Input.GetAxis("Vertical") * speed * transform.forward;
    }
}
