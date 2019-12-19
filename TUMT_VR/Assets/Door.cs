using UnityEngine;

public class Door : MonoBehaviour {


    public Animator animtorControl;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider"&&Game.havekey==true) {

            animtorControl.SetBool("character_nearby",true);
        }
    }

}
