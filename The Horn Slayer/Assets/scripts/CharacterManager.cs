using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public Animator hornAnim;
    public AudioSource hornSound;

    GameObject bulletInstance;
    public GameObject bullet;
    public Transform pos;

    bool canFire;
    public float maxTime;
    float time;
    public float bulletForce;

	void Start () {
	}
	
	void Update () {


        if (Input.GetMouseButtonDown(0) && canFire)
        {
            hornAnim.SetBool("canFire", true);
            hornSound.Play();
            canFire = false;
            bulletInstance = Instantiate(bullet, pos.position, Quaternion.identity);
            bulletInstance.GetComponent<Rigidbody>().AddForce(pos.transform.forward * bulletForce);
        }

        if (Input.GetMouseButtonUp(0))
        {
            hornAnim.SetBool("canFire", false);
        }

        if(canFire == false)
        {
            time--;
        }
        if(time <= 0)
        {
            canFire = true;
            time = maxTime;
        }
    }
}
