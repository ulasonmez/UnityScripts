using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Vector2 MouseDirection;
    private Transform myBody;
    void Start()
    {
        myBody = this.transform.parent.transform;
    }

    void Update()
    {
        Vector2 MouseC = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        MouseDirection += MouseC;
        this.transform.localRotation = Quaternion.AngleAxis(-MouseDirection.y, Vector3.right);
        myBody.localRotation = Quaternion.AngleAxis(MouseDirection.x, Vector3.up);
    }
}
