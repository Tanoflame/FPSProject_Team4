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
    public int AmmoCur;
    public int AmmoMax;

    public GameObject Model;
    public ParticleSystem HitEffect;
    public AudioClip ShootSound;
    [Range(0, 1)] public float ShootSoundVol;


}