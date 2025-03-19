using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    public float TurnTime = 0.1f;
    float TurnVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 DIR = new Vector3(horizontal, 0f, vertical);

        if (DIR.magnitude >= 0.1)
        {
            float targetAngle = Mathf.Atan2(DIR.x, DIR.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnVelocity, TurnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 WishDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(WishDir.normalized * speed * Time.deltaTime);
        }
    }
}
