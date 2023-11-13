using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Red : MonoBehaviour
{
    public Star_Obj star;
    public BoxCollider2D other_star;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (star.red_cnt == 2)
            {
                star.red_cnt = 0;
                collision.gameObject.transform.position = other_star.gameObject.transform.position;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            star.red_cnt++;
        }
    }
}
