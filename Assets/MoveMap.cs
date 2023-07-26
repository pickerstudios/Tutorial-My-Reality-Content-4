using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    public float WaitTime, ResetTime;
    private bool Portal = false;

    
    private IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(WaitTime);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Map");
    }


    private void OnTriggerEnter(Collider other)
    {
        Portal = true;
        if (other.gameObject.tag == "Player")
        {
           
              StartCoroutine(LoadScene());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Portal = false;
        WaitTime = ResetTime;
    }
}
