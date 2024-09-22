using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    public Camera cam;
    public pMove pm;
    public float mouseSensi = 100f;

    private float xRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pm = playerBody.GetComponent<pMove>();
        cam = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensi * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensi * Time.deltaTime;

        xRot = xRot - mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (pm.isDashing)
            StartCoroutine(upFov(75));
        else
            StartCoroutine(dnFov(60));
    }

    IEnumerator upFov(float target)
    {
        while (cam.fieldOfView < target)
        {
            cam.fieldOfView = cam.fieldOfView + 0.2f;
            yield return new WaitForSeconds(0.005f);
        }

        cam.fieldOfView = target;
    }

    IEnumerator dnFov(float target)
    {
        while (cam.fieldOfView > target)
        {
            cam.fieldOfView = cam.fieldOfView - 0.2f;
            yield return new WaitForSeconds(0.005f);
        }

        cam.fieldOfView = target;
    }
}
