using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {

    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;

    private void Start()
    {
        GameObject leader = GameObject.Instantiate<GameObject>(prefab);
        leader.transform.parent = this.transform;
        leader.transform.position = this.transform.position;
        leader.transform.rotation = this.transform.rotation;

        Seek seek = leader.AddComponent<Seek>();
        seek.target = leader.transform.position + leader.transform.forward * 1000;

        FollowCamera fc = FindObjectOfType<FollowCamera>();
        fc.target = leader;

        for (int i = 1; i <=followers; i++)
        {
            Vector3 offset = new Vector3(gap * i, 0, - gap * i);
            GameObject follower = CreateFollower(offset, leader.GetComponent<Boid>());
            offset = new Vector3(- gap * i, 0, - gap * i);
            follower = CreateFollower(offset, leader.GetComponent<Boid>());            
        }
    }

    GameObject CreateFollower(Vector3 offset, Boid leader)
    {
        GameObject follower = GameObject.Instantiate<GameObject>(prefab);
        follower.transform.position = this.transform.TransformPoint(offset);
        follower.transform.parent = this.transform;
        follower.transform.rotation = this.transform.rotation;
        OffsetPursue op = follower.AddComponent<OffsetPursue>();
        op.leader = leader;
        return follower;
    }


	// Update is called once per frame
	void Update () {
		
	}
}
