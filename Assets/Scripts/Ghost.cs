using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    [SerializeField] float mouseSensitivity = 100f;
    Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotating();
    }


    private void rotating()
    {
        float mouseX = Input.GetAxisRaw("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y")*mouseSensitivity*Time.deltaTime;

        rotateValue.x += mouseY;
        rotateValue.y += mouseX;

        transform.rotation = Quaternion.Euler(rotateValue);
    }
}
