using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColliderScript : MonoBehaviour
{
    public GameObject WINTEXT;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            WINTEXT.SetActive(true);
        }
    }

    /*
    //Move levels
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    */


    /*
        //Win SCREEN
    public Text WINTEXT;

        //Win SCREEN
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            WINTEXT.gameObject.SetActive(true);
        }
        if (true)
        {
            Debug.Log("Yes");
        }
    }
    */
}
