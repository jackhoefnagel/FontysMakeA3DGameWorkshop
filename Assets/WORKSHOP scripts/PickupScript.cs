using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

    GameObject pickupGraphicsObject;

    public int pickupScore = 1;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Player"){
            PickupManager.instance.PickupCoin(this);
        }
    }
}
