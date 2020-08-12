using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 10.0f;
    public Vector3 offset = new Vector3(0.0f, 10.0f, -5.0f);

    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(player);
    }
}
