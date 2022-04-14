/**** 
 * Created by: Garron Denney
 * Date Created: April 13, 2022
 * 
 * Last Edited by:
 * Last Edited: 
 * 
 * Description: Returning Objects to pool
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; //find the game manager

    }//end Start()

    private void OnDisable()
    {
        //if the pool is not empty
        if ( pool != null)
        {
            pool.ReturnObject(this.gameObject); //return to pool
        }//end if ( pool != null)
        
    }//end OnDisable()


    // Update is called once per frame
    void Update()
    {
        
    }
}
