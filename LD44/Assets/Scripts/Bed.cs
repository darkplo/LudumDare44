using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
	BoxCollider2D m_collider;
	private bool isColliding;
	private Collider2D objectColliding;
    public GameObject image1;
    public float delay = 3f;
    private float t_time = 0f;

    // Start is called before the first frame update
    void Start()
	{
		isColliding = false;
		m_collider = GetComponent<BoxCollider2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (isColliding)
		{
			InputsManager iPlayer = objectColliding.GetComponent<InputsManager>();
			if (iPlayer == null)
				return;
			if (iPlayer.interract)
			{
				iPlayer.interract = false;
				iPlayer.GetComponent<Player>().Dead(dead.Bed);
                image1.SetActive(true);
            }
		}
        if (image1.activeInHierarchy)
        {
            t_time += Time.fixedDeltaTime;
            if (t_time >= delay)
            {
                image1.SetActive(false);
                t_time = 0;
                Destroy(gameObject);
            }
        }
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		InputsManager iPlayer = col.GetComponent<InputsManager>();
		if (iPlayer != null)
		{
			iPlayer.p_up = false;
			iPlayer.p_down = false;
			iPlayer.interract = false;
			isColliding = true;
			objectColliding = col;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		isColliding = false;
		objectColliding = null;
	}
}
