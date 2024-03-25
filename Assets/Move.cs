using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;

    void Start() {

        //this.transform.Translate(goal.transform.position);
        this.transform.Translate(4,0,7);
    }

    private void Update() {

    }
}
