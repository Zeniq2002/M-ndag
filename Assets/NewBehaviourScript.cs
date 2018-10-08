using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public SpriteRenderer rend;
    public float rotationSpeed = 360; //rotationfarten
    public float moveSpeed = 6f;//rörelsefarten
    public float vänsterRotation = 180; //rotationfarten åt vänster
    public int Vector3;
 

    void Start()
    {
        //  skeppet spawnar på en random position innanför skärmen när spelet startar
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
            transform.position = position;
    }

    void Update()
    {
        // ger skeppet en konstatn fart framåt
        transform.Translate(0, 4 * Time.deltaTime, 0, Space.Self);

        // Trycker du på A så roterar du åt vänster och blir grön
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, vänsterRotation * Time.deltaTime);
            rend.color = Color.green;
        }
        // Trycker du på D så roterar du åt vänster och blir blå
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            rend.color = Color.blue;
        }
        // Trycker du på S så halverar du farten på skeppet
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -2 * Time.deltaTime, 0, Space.Self);
        }
        // ger skepet en random färg när man trycker på Space
        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        if (transform.positionx >1)

        {

        }
    }

}