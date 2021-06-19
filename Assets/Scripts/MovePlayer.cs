using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Animator m_animator;
    public float m_Speed;
    // [SerializeField] public Animator m_Animator;
    // 요 코드랑 똑같음 
    // 1. [SerializeField] 가 있어애 Inspector 창에 벙;ㄴ디 
    // 2. public 인데 inspector 에 안보이고 싶다면 
    // [System.Nonserialized] 를 붙여야 한다
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        m_animator.SetBool("isMove", false);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            m_animator.SetBool("isMove", true);
            transform.Translate(m_Speed, 0, 0);
        }
        else  if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            m_animator.SetBool("isMove", true);
            transform.Translate(-m_Speed, 0, 0);
        }
      
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            m_animator.SetBool("isMove", true);
            transform.Translate(0, 0, -m_Speed);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            m_animator.SetBool("isMove", true);

            transform.Translate(0, 0, m_Speed);
        }
      
    }
}
