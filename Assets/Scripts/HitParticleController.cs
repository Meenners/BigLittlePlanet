using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitParticleController : MonoBehaviour {

    public int hitpoints = 15;
    private Material particleMat;

    [ExecuteInEditMode]
    private void Start()
    {
        GetComponent<ParticleSystemRenderer>().material.mainTextureOffset = new Vector2((hitpoints - 1) * 0.04f , 0);
        Destroy(this.gameObject, 1f);
    }
}
