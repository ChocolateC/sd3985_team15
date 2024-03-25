using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);

        Vector2 position = transform.position;

        direction = RotateVector(direction, 90);

        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //position.y = position.y + 3.0f * vertical * Time.deltaTime;

        position += direction * 3.0f * Time.deltaTime;
        transform.position = position;
    }
    Vector2 RotateVector(Vector2 vector, float angle)
    {
        Quaternion rotation = Quaternion.Euler(0f, 0f, angle);
        Vector2 rotatedVector = rotation * vector;
        return rotatedVector;
    }
}
