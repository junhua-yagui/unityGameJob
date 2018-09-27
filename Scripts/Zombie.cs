using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    public NavMeshAgent agent;
    public people player;
    public Animation ani;//cartoon module
    public AnimationClip curClip;//the cartoon clip at present

    public float distance = 0;
    public float attackLength = 2.5f;

    //enum the actions for zombie
    public enum ActionType
    {
        IDLE, ATTACK, FALLINGBACK, WALK
    }


    //the action at present
    public ActionType _curAction;
    #region curAction
    public ActionType CurAction
    {
        get { return _curAction; }
        set
        {
            _curAction = value;
            string aniName = "";
            switch (_curAction)
            {
                case ActionType.ATTACK:
                    aniName = "attack";
                    break;
                case ActionType.IDLE:
                    aniName = "idle";
                    break;
                case ActionType.FALLINGBACK:
                    aniName = "fallingback";
                    break;
                case ActionType.WALK:
                    aniName = "walk";
                    break;
            }
            //get the cartoon clip at present
            curClip = ani.GetClip(aniName);

            //play the action
            ani.CrossFade(aniName);

            //creat the event of cartoon
            AnimationEvent ae = new AnimationEvent();
            //the method's parameter
            ae.stringParameter = curClip.name;
            //creat the method of callback lag
            ae.functionName = "ActionEnd";
            //the time for callback lag
            ae.time = curClip.length - 0.1f;
            //add the event to the cartoon clip
            curClip.AddEvent(ae);
        }

    }


    //the callback lag after cartoon 
    public void ActionEnd(string clipName)
    {
        Debug.Log(clipName + "结束了");
    }
    #endregion

    // Use this for initialization
    void Start()
    {
        CurAction = ActionType.IDLE;
    }

	// Update is called once per frame
	void Update () {
        agent.speed = 2.5f;
        agent.SetDestination(player.transform.position);

        //count the distance
        distance = Vector3.Distance(this.transform.position,player.transform.position);

        //when idle
        if (CurAction == ActionType.IDLE)
        {
            if (distance <= attackLength)//get the enemy
            {
                CurAction = ActionType.ATTACK;
                agent.ResetPath();//reset the way to go
            }
            else//not get the enemy
            {
                CurAction = ActionType.WALK;
                agent.speed = 2.5f;
                agent.SetDestination(player.transform.position);
            }
        }

        //when walk
        if (CurAction == ActionType.WALK)
        {
            if (distance <= attackLength)
            {
                agent.ResetPath();//stop
                CurAction = ActionType.ATTACK;
            }
            else
            {
                CurAction = ActionType.WALK;
                agent.speed = 2.5f;
                agent.SetDestination(player.transform.position);
            }
        }

        //when attack
        if (CurAction == ActionType.ATTACK)
        {
        }

        //when fallback
        if (CurAction == ActionType.FALLINGBACK)
        {

        }


	}
}
