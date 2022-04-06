
/**** 
 * Created by: Garron Denney
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Garron Denney
 * Last Edited: N/A
 * 
 * Description: Pool of objects for re - use
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;
    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; //reference to pool

    }//end Start()


    private void OnDisable()
    {
        if(pool != null)
        {
            pool.ReturnObjects(this.gameObject);
        }
    }//end OnDisable
    
}
