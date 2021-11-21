using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public bool opposite;
    public float speed;

    private float privateSpeed;

    private ScreenBoundaryManager boundaryManager;

    // Start is called before the first frame update
    void Start()
    {
        boundaryManager = new ScreenBoundaryManager();
    }

    // Update is called once per frame
    void Update()
    {
        privateSpeed = opposite ? -1 * speed : speed;

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0) * privateSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0) * privateSpeed;
        }

        // keep the spaceship in screen bounds
        boundaryManager.keepInBoundaries(this.gameObject);
    }
}
