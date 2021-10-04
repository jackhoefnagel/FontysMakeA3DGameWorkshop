using UnityEngine;
using System.Collections;

public class DieObjectScript : MonoBehaviour {

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Player"){
            GameManager.instance.PlayerEntersDieObject();
        }
    }
}
