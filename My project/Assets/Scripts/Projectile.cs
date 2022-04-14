/**** 
 * Created by: Garron Denney
 * Date Created: April 13, 2022
 * 
 * Last Edited by: 
 * Last Edited: April 13, 2022
 * 
 * Description: Projectile Logic
****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    /*** Variables***/
    private BoundsCheck bndCheck; //reference to the bounds check
    private void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end Awake()

    // Update is called once per frame
    void Update()
    {
        //if off screen up , destroy
        if (bndCheck.offUp)
        {
           gameObject.SetActive(false); //set the projectile to deactivate and return to pool
        }
    //if off-screen up, destroy
    
    if(bndCheck.offUp)
    {
        gameObject.SetActive(false); //set the project to deactivate and return to pool
        bndCheck.offUp = false; //reset the BoundsCheck offUp boolean
    }

    }//end update()

}
