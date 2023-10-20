using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTransition : MonoBehaviour
{
    public string SceneToTransitionTo = "";


    // called when the cube hits the floor
    void OnTriggerEnter2D(Collider2D col)
    {
        TopDownPlayerBehaviour player = col.gameObject.GetComponent<TopDownPlayerBehaviour>();

        if(player!=null){

            if(SceneToTransitionTo!=""){
                SceneManager.LoadScene(SceneToTransitionTo);
            }
        }
    }
}
