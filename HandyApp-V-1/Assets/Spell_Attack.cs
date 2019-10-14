using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Attack : MonoBehaviour
{
    public Spell_Dictonary spell_Dictonary;
    public int Spell;
    public float Speed;
    public Transform shootPoint;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(shoot());
            animator.SetTrigger("attack1");
        }
    }
    IEnumerator shoot()
    {
        yield return new WaitForSeconds(0.9F);
        var SpellObject = Instantiate(spell_Dictonary.GetGameObject(Spell), shootPoint.position, transform.rotation);
        SpellObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * Speed);
        
    }
}
