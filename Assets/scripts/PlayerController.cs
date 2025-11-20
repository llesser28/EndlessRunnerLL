using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravityModifier;
    [SerializeField] private ParticleSystem explosionparticel;
    [SerializeField] private ParticleSystem dirtParticle;
    [SerializeField] private AudioClip jumpsound;
    [SerializeField] private AudioClip crashSound;
    private Animator playerAnimation;
    private AudioSource playeraudio;
    private Rigidbody playerRB;
    private bool isOnGround;
    public bool gameOver { get;private set;}


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        isOnGround = true;
        Physics.gravity *= gravityModifier;

    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && isOnGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            isOnGround = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
