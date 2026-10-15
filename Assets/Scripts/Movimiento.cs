using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float velocidad = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            Debug.Log("mov, izquierdo");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            Debug.Log("mov, derecho");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            Debug.Log("mov, arriba");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            Debug.Log("mov,abajo");
        }
    }
}
