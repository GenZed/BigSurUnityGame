using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class tvPlayer : MonoBehaviour

{
    public VideoPlayer vp;

    public GameObject TV;
    
    // Start is called before the first frame update
    void Start()
    {
       vp = gameObject.GetComponent<VideoPlayer>();
       

        {

            vp.Stop();

            vp.audioOutputMode.Equals(false);
        }

      
        
    }






    // Update is called once per frame

    private void Update()
    {

       // vp.audioOutputMode.Equals(false);

    }


    private void //OnBecameVisible()
                 
        OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        //enabled = true;

        {
            //TV.SetActive(true);
            vp.Play();

            vp.audioOutputMode.Equals(true);
                //SetBool("Play", true);
        }


    }

    private void //OnBecameInvisible()
        OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))

        //enabled = false;

        {
            vp.Stop();

            vp.audioOutputMode.Equals(false);


            //SetBool("Play", false);
        }

    }
}
