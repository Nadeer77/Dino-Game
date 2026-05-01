using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;
    public float gravity = 9.81f * 2;
    public float jumpForce = 8f;
    void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    void OnEnable()
    {
        direction = Vector3.zero;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;

        if(character.isGrounded)
        {
            direction = Vector3.down;

            if(Input.GetButton("Jump"))
            {
                direction = Vector3.up * jumpForce;
            }
        }
        character.Move(direction * Time.deltaTime);
    }
}
