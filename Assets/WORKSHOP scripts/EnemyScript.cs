using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    private Collider[] objectsNearby;
   
	void Update () {
        
        objectsNearby = Physics.OverlapSphere(transform.position, GameManager.instance.enemyTouchRadius);

        foreach(Collider coll in objectsNearby){
            if(coll.tag == "Player"){
                GameManager.instance.GameOver();
            }
        }   
	}
}
