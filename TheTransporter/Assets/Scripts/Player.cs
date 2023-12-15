using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float steerSpeed = 50f;
    [SerializeField] float accelerateSpeed = 10f;
    [SerializeField] public bool hasPackage;
    [SerializeField] public bool canTransform;

    [SerializeField] Sprite car1;
    [SerializeField] Sprite car2;

    SpriteRenderer mySpriteRenderer;

    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float accelerateAmount = Input.GetAxis("Vertical") * accelerateSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, accelerateAmount, 0);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (canTransform == true)
            {
                Debug.Log("Car 1 selected");
                mySpriteRenderer.sprite = car1;
                steerSpeed = 50f;
                accelerateSpeed = 10f;
            }
            else
            {
                Debug.Log("Transformation is locked until you deliver a package");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (canTransform == true)
            {
                Debug.Log("Car 2 selected");
                mySpriteRenderer.sprite = car2;
                steerSpeed = 70f;
                accelerateSpeed = 20f;
            }
            else
            {
                Debug.Log("Transformation is locked until you deliver a package");
            }
        }
    }
}
