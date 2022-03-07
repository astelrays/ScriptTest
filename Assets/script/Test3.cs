using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  class Boss
    {
        int hp=100;
        int power=25;

        int mp=53;

        public void Attack()
        {
            Debug.Log(this.power+"のダメージを与えた");

        }
        public void Defence(int damage)
        {
            Debug.Log(damage+"のダメージを受けた");

            this.hp-=damage;

        }
        public  void   MagicAttack(int a)
        { 
            if (this.mp>=5)
            {
             this.mp-=a;
             Debug.Log("魔法攻撃をした。残りMPは"+this.mp);
            }
            else 
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
             
            

        }
    
    }  
public class Test3 : MonoBehaviour
{
    Boss lastboss=new Boss();


    // Start is called before the first frame update
    void Start()
    {
        

        lastboss.Attack();

        lastboss.Defence(3);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        lastboss.MagicAttack(5);
        
    }
}
