using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moves the players position depending on the inputs of WASD.
        rb.velocity = Input.GetAxis("Horizontal") * speed * transform.right + new Vector3(0, rb.velocity.y, 0) + Input.GetAxis("Vertical") * speed * transform.forward;

        //Only activates upon pressing space if the player is > 1.3 from the ground
        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(transform.position, transform.up * -1, 1.3f))
        {
            //adds an upward force to the player (Jump).
            rb.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
        }
    }
}
