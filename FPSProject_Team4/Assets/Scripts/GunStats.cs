using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu] //lets u right click on the prefab menu to create gun stats at the top


public class gunStats : ScriptableObject
{
    [Header("----- Stats -----")]
    public int ShootDamage;
    public float ShootRate;
    public int ShootDist;

    public int ammoCount;
    public int ammoMag;
    public int ammoReserve;

    public int ammoReserveDefault;

    public float armorPen;
    public float reloadTime;

    public GameObject Model;
    public ParticleSystem HitEffect;
    public AudioClip ShootSound;
    [Range(0, 1)] public float ShootSoundVol;


    //add bools for ads/coach gun logic stuff 

}
