using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Player Movement")]
    public float playerSpeed =1.1f;

    [Header("Player Animator & Gravity")]
    public CharacterController cc;

    private void Update(){
        playerMove();
    }

    void playerMove(){
        float horizotal_axis = Input.GetAxisRaw("Horizontal");
        float vertical_axis = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizotal_axis,0f,vertical_axis).normalized;
        if (direction.magnitude >= 0.1f){
            float targetAngle =  Mathf.Atan2(direction.x , direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle , 0f);
            cc.Move(direction.normalized * playerSpeed*Time.deltaTime);

        }
    }
    
}
