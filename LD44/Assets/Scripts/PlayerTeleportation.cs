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
            InputsManager iPlayer = objectColliding.GetComponent<InputsManager>();
            if (iPlayer == null)
                return;
            if (iPlayer.p_up && upTP != null) {
                iPlayer.GetComponent<Transform>().position = upTP.transform.position;
            }
            else if (iPlayer.p_down && downTP != null) {
                iPlayer.GetComponent<Transform>().position = downTP.transform.position;
            }
            iPlayer.p_up = false;
            iPlayer.p_down = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        InputsManager iPlayer = col.GetComponent<InputsManager>();
        if (iPlayer != null) {
            iPlayer.p_up = false;
            iPlayer.p_down = false;
            isColliding = true;
            objectColliding = col;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        isColliding = false;
        objectColliding = null;
    }
}
