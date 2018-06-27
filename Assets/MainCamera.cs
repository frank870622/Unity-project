using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public float cameraMoveAmount;
    public float cameraZoomAmount;


    private float moveBorder = 10;
    private float screenWidthQuarter = Screen.width / 4;
    private float screenHeightQuarter = Screen.height / 4;
    // Use this for initialization
    void Start()
    {
        //myCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraMove();
        cameraZoom();
    }

    private void cameraMove()
    {
        if (Input.mousePosition.y < moveBorder)
        {
            transform.position -= transform.up * Time.deltaTime * cameraMoveAmount;
            if (Input.mousePosition.x < screenWidthQuarter)
                transform.position -= transform.right * Time.deltaTime * cameraMoveAmount;
            else if (Input.mousePosition.x > Screen.width - screenWidthQuarter)
                transform.position += transform.right * Time.deltaTime * cameraMoveAmount;
        }
        else if (Input.mousePosition.y > Screen.height - moveBorder)
        {
            transform.position += transform.up * Time.deltaTime * cameraMoveAmount;
            if (Input.mousePosition.x < screenWidthQuarter)
                transform.position -= transform.right * Time.deltaTime * cameraMoveAmount;
            else if (Input.mousePosition.x > Screen.width - screenWidthQuarter)
                transform.position += transform.right * Time.deltaTime * cameraMoveAmount;
        }
        else if (Input.mousePosition.x < moveBorder)
        {
            transform.position -= transform.right * Time.deltaTime * cameraMoveAmount;
            if (Input.mousePosition.y < screenHeightQuarter)
                transform.position -= transform.up * Time.deltaTime * cameraMoveAmount;
            else if (Input.mousePosition.y > Screen.height - screenHeightQuarter)
                transform.position += transform.up * Time.deltaTime * cameraMoveAmount;
        }
        else if (Input.mousePosition.x > Screen.width - moveBorder)
        {
            transform.position += transform.right * Time.deltaTime * cameraMoveAmount;
            if (Input.mousePosition.y < screenHeightQuarter)
                transform.position -= transform.up * Time.deltaTime * cameraMoveAmount;
            else if (Input.mousePosition.y > Screen.height - screenHeightQuarter)
                transform.position += transform.up * Time.deltaTime * cameraMoveAmount;
        }
    }

    private void cameraZoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f && transform.position.y >= 15)
            transform.position += transform.forward * Time.deltaTime * cameraZoomAmount;

        if (Input.GetAxis("Mouse ScrollWheel") < 0f && transform.position.y <= 40)
            transform.position -= transform.forward * Time.deltaTime * cameraZoomAmount;

    }
}
