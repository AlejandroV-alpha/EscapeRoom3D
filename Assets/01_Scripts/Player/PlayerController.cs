using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stadistics")]
    public float speed = 7f;
    public float sprintSpeed = 10f; // Integrado de A
    public float crouchSpeed = 3f;  // Integrado de B


    private void Update()
    {
        Move();
        //Debug.Log("Movement system active");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction key pressed");
        }
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}