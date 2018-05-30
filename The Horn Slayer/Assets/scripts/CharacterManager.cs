using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public Animator hornAnim;
    public AudioSource hornSound;

	void Start () {
		
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            hornAnim.SetBool("canFire", true);
            hornSound.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
            hornAnim.SetBool("canFire", false);
        }
    }
}
