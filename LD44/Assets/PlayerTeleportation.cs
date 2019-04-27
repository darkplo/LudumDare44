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
    void FixedUpdate()
    {
        if (isColliding) {
            InputsPlayer iPlayer = objectColliding.GetComponent<InputsPlayer>();
            if (iPlayer == null)
                return;
            if (iPlayer.p_up && upTP != null) {
                Debug.Log("Collide + UP");
                iPlayer.GetComponent<Transform>().position = upTP.transform.position;
            }
            else if (iPlayer.p_down && downTP != null) {
                Debug.Log("Collide + DOWN");
                iPlayer.GetComponent<Transform>().position = downTP.transform.position;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.GetComponent<InputsPlayer>() != null) {
            isColliding = true;
            objectColliding = col;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        isColliding = false;
        objectColliding = null;
        Debug.Log("stop collide");
    }
}
