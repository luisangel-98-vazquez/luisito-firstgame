using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float fuerza = 8f;

    private Rigidbody2D rb;
    private CambioColor cambioColor;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cambioColor = GetComponent<CambioColor>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(
            horizontal,
            vertical
        );

        if (Input.GetKey(KeyCode.A))
        {
            cambioColor.CambiarColor(Color.red);
            Debug.Log("mov, izquierdo");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            cambioColor.CambiarColor(Color.blue);
            Debug.Log("mov, derecho");
        }

        if (Input.GetKey(KeyCode.W))
        {
            cambioColor.CambiarColor(Color.green);
            Debug.Log("mov, arriba");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            cambioColor.CambiarColor(Color.yellow);
            Debug.Log("mov, abajo");
        }

        rb.AddForce(direccion * fuerza);
    }
}