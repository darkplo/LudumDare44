using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportation : MonoBehaviour
{
    public GameObject upTP;
    public GameObject downTP;

    BoxCollider2D m_collider;
    // Start is called before the first frame update
    void Start()
    {
        m_collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.GetComponent<InputsPlayer>() != null)
            Debug.Log("collide");
    }

    void OnTriggerExit2D(Collider2D col) {
        Debug.Log("stop collide");
    }
}
