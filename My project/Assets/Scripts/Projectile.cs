/**** 
 * Created by: Garron Denney
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Garron Denney
 * Last Edited: N/A
 * 
 * Description: Projectile Behavior
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /***VARIABLES***/
    private BoundsCheck bndCheck; //reference to bounds check


    // Start is called before the first frame update

    private void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bndCheck.offUp)
        {
            gameObject.SetActive(false);
            bndCheck.offUp = false;
        }
    }
}
