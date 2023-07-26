using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_View_Switch : MonoBehaviour
{
     Controller ConT;
    
    public string Animtrigger;
    public Animator anim;

    public Canvas CanVasObject;
   

    private void Start()
    {
        
        CanVasObject.gameObject.SetActive(false);
    }
    private void OnTriggerEnter( Collider other)
    {
        
        anim.SetTrigger(Animtrigger);
        CanVasObject.gameObject.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
       
        anim.SetTrigger("Default");
        CanVasObject.gameObject.SetActive(false);
    }
    public void DefaultCam ()
    {
        anim.SetTrigger("Default");
    }
 
}
