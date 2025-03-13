using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)//检测 Ruby 与可收集的生命值游戏对象发生碰撞的情况，并向她提供一些生命值
    {
        //名为 other 的参数将包含刚进入触发器的碰撞体
        //Debug.Log("Object that entered the trigger : "+ other);//以检查是什么进入了触发器
        RubyController controller =other.GetComponent<RubyController>();
        if (controller!=null)
        {
            {
            controller.ChangeHealth(-1);
            }
        }

    }
}
