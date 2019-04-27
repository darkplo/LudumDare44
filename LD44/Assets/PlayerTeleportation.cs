using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportation : MonoBehaviour
{
    public GameObject upTP;
    public GameObject downTP;

    BoxCollider2D m_collider;
    private bool isColliding;
    private Collider2D objectColliding;
    // Start is called before the first frame update
    void Start()
    {
        isColliding = false;
        m_collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding) {
            InputsPlayer iPlayer = objectColliding.GetComponent<InputsPlayer>();
            if (iPlayer == null)
                return;
            if (iPlayer.interract)
                Debug.Log("INTERRACT");
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        isColliding = true;
        objectColliding = col;
    }

    void OnTriggerExit2D(Collider2D col) {
        isColliding = false;
        objectColliding = null;
        Debug.Log("stop collide");
    }
}
