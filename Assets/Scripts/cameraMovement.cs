using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

	 public float offset;
    public float speed;
    public Vector2 minMaxXPosition;
    private float screenWidth;
    private Vector3 cameraMove;
    // Use this for initialization
    void Start()
    {
        screenWidth = Screen.width;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.mousePosition.x > screenWidth/4*3) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < screenWidth/4) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        transform.position = cameraMove;
    }
    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}
