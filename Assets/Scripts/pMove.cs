using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMove : MonoBehaviour
{
    [Header("Refs")]
    public CharacterController ctrl;
    public Transform groundCheck;

    [Header("Player Values")]
    public float pSpeed;
    public float pJumpHeight;
    public float gravity;

    [Header("Ground Check")]
    public bool isGround;
    public float checkerSize;
    public LayerMask groundMask;

    [Header("Dash Check")]
    public bool isDashing;
    public bool canDash;
    public int dashDistance;
    public float dashCD;
    public Vector2 dashDir;

    [Header("Speed")]
    [SerializeField] private Vector3 velo;
    [SerializeField] private Vector3 speed;

    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        ctrl = GetComponent<CharacterController>();
        isDashing = false;
        canDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, checkerSize, groundMask);

        if (isGround && velo.y < 0f)
            velo.y = -5f;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        dashDir = new Vector2(x, z).normalized;
        
        // Walk
        move = transform.right * x + transform.forward * z;

        ctrl.Move(move * pSpeed * Time.deltaTime);
        speed = move * pSpeed;

        // Dash
        if (!isDashing && canDash && Input.GetButtonDown("Dash"))
        {   
            canDash = false;
            isDashing = true;
            Vector3 dash = transform.right * dashDir.x + transform.forward * dashDir.y;

            StartCoroutine(dashMove(dash, dashDistance));
            Invoke(nameof(dashReset), dashCD);
        }

        // Jump
        if (isGround && Input.GetButtonDown("Jump"))
            velo.y = Mathf.Sqrt(pJumpHeight * -2f * gravity);

        velo.y += gravity * Time.deltaTime;
        ctrl.Move(velo * Time.deltaTime);
    }

    void dashReset()
    {
        ctrl.Move(move * pSpeed * Time.deltaTime);
        canDash = true;
    }

    IEnumerator dashMove(Vector3 dash, int dashDist)
    {
        dash = dash * 0.1f;
        int count = 0;

        while (count < dashDist)
        {
            ctrl.Move(dash);
            count++;
            yield return new WaitForSeconds(0.005f);
        }

        isDashing = false;
    }
}
