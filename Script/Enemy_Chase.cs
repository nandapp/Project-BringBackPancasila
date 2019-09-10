using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent myAgent;
    private Animator myAnimator;

    public Transform target;
	public Transform target2;

    public bool chaseTarget = true;
    public float stoppingDistance;
    public float delayBetweenAttacks = 1.5f;
    private float attackCooldown;

    private float distanceFromTarget;

    private Player_Health playerhealth;
    public int damage = 50;

	public Flashlight FL;
	private AudioSource audioSource;
	public AudioClip chaseSound;
	public AudioClip AttackSound;

    // Use this for initialization
    void Start ()
    {
        myAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
        myAgent.stoppingDistance = stoppingDistance;
        attackCooldown = Time.time;

        playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Health>();

		audioSource = GetComponent<AudioSource>();
		//GetComponent<Flashlight>().isActive = FL;
    }
	
	// Update is called once per frame
	void Update ()
    {
		ChaseTarget();
		if (FL.isActive == false) 
		{
			//ChaseTarget();
			distanceFromTarget = Vector3.Distance(target.position, transform.position);
			if (distanceFromTarget >= stoppingDistance)
			{
				chaseTarget = true;

				audioSource.PlayOneShot(chaseSound);
			}
			else
			{
				chaseTarget = false;
                audioSource.PlayOneShot(AttackSound);
                Attack();
			}

			if(chaseTarget)
			{
				myAgent.SetDestination(target.position);
				myAnimator.SetBool("isChasing", true);
				myAnimator.SetBool("isChasing2", true);

			}
		} 
		else if (FL.isActive == true) 
		{
			myAgent.SetDestination(target2.position);
			myAnimator.SetBool("isChasing", false);
			myAnimator.SetBool("isChasing2", false);
		}
	}

    public void ChaseTarget()
    {
        /*distanceFromTarget = Vector3.Distance(target.position, transform.position);
        if (distanceFromTarget >= stoppingDistance)
        {
            chaseTarget = true;

			audioSource.PlayOneShot(chaseSound);
        }
        else
        {
            chaseTarget = false;
            Attack();
        }
        
        if(chaseTarget)
        {
            myAgent.SetDes=tination(target.position);
            myAnimator.SetBool("isChasing", true);
            myAnimator.SetBool("isChasing2", true);
            
        }*/
        /*else
        {
            myAnimator.SetBool("isChasing", false);
        }*/
    }

    void Attack()
    {
        if(Time.time > attackCooldown)
        {
            playerhealth.TakeDamage(damage);
            myAnimator.SetTrigger("Attack");
            attackCooldown = Time.time + delayBetweenAttacks;
			//audioSource.PlayOneShot(AttackSound);
        }
    }
}
