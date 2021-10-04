using UnityEngine;
using System.Collections;

public class EndObjectScript : MonoBehaviour {

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Player"){
            GameManager.instance.PlayerEntersEndObject();
        }
    }
}
