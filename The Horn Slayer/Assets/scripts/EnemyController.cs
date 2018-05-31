using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    NavMeshAgent agent;
    public Animator anim;

    bool canFollow;

	void Start () {
        canFollow = true;
        agent = GetComponent<NavMeshAgent>();
    }
	
	void Update () {
        if (canFollow)
        {
            agent.SetDestination(FindObjectOfType<CharacterController>().transform.position);
            anim.SetBool("walking", true);
        }
        else
        {
            agent.ResetPath();
            anim.SetBool("walking", false);
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            anim.SetBool("canFall", true);
            canFollow = false;
            agent.enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
