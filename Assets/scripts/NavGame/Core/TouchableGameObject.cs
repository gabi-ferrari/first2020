using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Core
{

    public class TouchableGameObject : MonoBehaviour
    {
        public float contactRadius = 0.5f;
        public bool IsInTouch(TouchableGameObject other)
        {
            float distance = Vector3.Distance(transform.position, other);
            return distance < contactRadius + other.contactRadius;
        } 

        protected virtual void OnDrawGizmosSelected() 
        {
            Gismos.color = Color.yellow;
            Gismos.DrawWireSphere(transform.position, contactRadius);
        }
    }
}