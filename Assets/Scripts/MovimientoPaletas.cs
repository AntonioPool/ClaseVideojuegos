using UnityEngine;

public class MovimientoPaletas : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveSpeed = 10f;


    public float minX = -9f;
    public float maxX = 0f;
    public float minY = -4.5f;
    public float maxY = -4.5f;

    public enum ControlType { WasdKeys, ArrowKeys }
    public ControlType controlType;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if(controlType == ControlType.WasdKeys)
        {
            if (Input.GetKey(KeyCode.W)) moveY += 1f; 
            if (Input.GetKey(KeyCode.S)) moveY -= 1f; 
            if (Input.GetKey(KeyCode.A)) moveX -= 1f; 
            if (Input.GetKey(KeyCode.D)) moveX += 1f; 
        }

        else if(controlType == ControlType.ArrowKeys)
        {
            if (Input.GetKey(KeyCode.UpArrow)) moveY += 1f;
            if (Input.GetKey(KeyCode.DownArrow)) moveY -= 1f;
            if (Input.GetKey(KeyCode.LeftArrow)) moveX -= 1f;
            if (Input.GetKey(KeyCode.RightArrow)) moveX += 1f;
        }

        Vector2 inputDirection = new Vector2(moveX, moveY).normalized;
        Vector2 targetVelocity = inputDirection * moveSpeed;

        rb.linearVelocity = targetVelocity;

        Vector2 clampedPosition = rb.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);
        rb.position = clampedPosition;
    }
}
