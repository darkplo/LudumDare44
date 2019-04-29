using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportation : MonoBehaviour
{

    public GameObject door_closed;
    public GameObject door_opened;
    public GameObject upTP;
    public GameObject downTP;

    BoxCollider2D m_collider;
    private bool isColliding;
    private Collider2D objectColliding;
    public InputsManager iPlayer;
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
            //iPlayer = objectColliding.GetComponent<InputsManager>();
            if (iPlayer == null)
                return;
            if (iPlayer.canMove && iPlayer.interract) {
                iPlayer.canMove = false;
                iPlayer.interract = false;
                iPlayer.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.GetComponent<SpriteRenderer>().sprite = door_opened.GetComponent<SpriteRenderer>().sprite;
            }
            else if (!iPlayer.canMove && iPlayer.interract) {
                iPlayer.canMove = true;
                iPlayer.interract = false;
                iPlayer.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.GetComponent<SpriteRenderer>().sprite = door_closed.GetComponent<SpriteRenderer>().sprite;
            }
            if (iPlayer.p_up && !iPlayer.canMove && upTP != null) {
                iPlayer.GetComponent<Transform>().position = upTP.transform.position;
                upTP.GetComponent<SpriteRenderer>().sprite = door_opened.GetComponent<SpriteRenderer>().sprite;
            }
            else if (iPlayer.p_down && !iPlayer.canMove && downTP != null) {
                iPlayer.GetComponent<Transform>().position = downTP.transform.position;
                downTP.GetComponent<SpriteRenderer>().sprite = door_opened.GetComponent<SpriteRenderer>().sprite;
            }
            iPlayer.p_up = false;
            iPlayer.p_down = false;
        }
        if (iPlayer && iPlayer.GetComponent<Player>().elevatorDead)
        {
            if (gameObject.GetComponent<SpriteRenderer>().sprite != door_closed.GetComponent<SpriteRenderer>().sprite
                && gameObject.GetComponent<SpriteRenderer>().sprite != door_opened.GetComponent<SpriteRenderer>().sprite)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = door_closed.GetComponent<SpriteRenderer>().sprite;
                if (isColliding)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = door_opened.GetComponent<SpriteRenderer>().sprite;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        InputsManager iPlayerI = col.GetComponent<InputsManager>();
        if (iPlayerI != null) {
            iPlayerI.p_up = false;
            iPlayerI.p_down = false;
            iPlayerI.interract = false;
            isColliding = true;
            objectColliding = col;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        isColliding = false;
        objectColliding = null;
        gameObject.GetComponent<SpriteRenderer>().sprite = door_closed.GetComponent<SpriteRenderer>().sprite;
    }
}
