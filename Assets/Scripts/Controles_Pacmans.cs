using UnityEngine;

public class Controles_Pacmans : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad = 10f;

    public enum ControlType { WasdKeys, ArrowKeys }
    public ControlType controlType;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (controlType == ControlType.WasdKeys)
        {
            if (Input.GetKey(KeyCode.W))transform.Translate(Vector3.up * velocidad * Time.deltaTime); 
            else if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            else if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            else if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        else if (controlType == ControlType.ArrowKeys)
        {
            if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            else if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            else if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            else if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
