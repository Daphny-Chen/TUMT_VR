using UnityEngine;

public class Game : MonoBehaviour {

    public static bool havekey;


    public void ThrowPickUp() {
        print("");
    }

    public void ThrowDetach(GameObject buj)
    {
        print("");
        havekey = true;
        Destroy(buj);
    }



    public void ThrowHeld()
    {
        print("");
    }




}
