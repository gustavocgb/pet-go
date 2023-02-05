using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxController : MonoBehaviour
{
    public Animator anim;
    public GameObject health;
    public float distanceLimit = 1f;
    public GameObject fox;
    public GameObject player;
    private bool flag = false;
    private float maxHealth = 600f;
    public HealthBar healthBar;
    public GameObject text;
    public FoxHealth FoxHealth;
    public PegarObjeto objeto;
    public int pocao;

    void Start()
    {
        objeto = GameObject.Find("Character").GetComponent<PegarObjeto>();
        anim = GetComponent<Animator>();
        FoxHealth = GetComponent<FoxHealth>();
        fox = GameObject.Find("Fox");
        player = GameObject.Find("Character");
        text.SetActive(false);
    }

    void Update()
    {
        if (Vector3.Distance(fox.transform.position, player.transform.position) < distanceLimit) {
            text.SetActive(true);
            anim.Play("Fox_Sit1");
            flag = true;
        }
        else if (flag) {
            text.SetActive(false);
            anim.Play("Fox_Attack_Paws");
            
            flag = false;
        }
        if (flag && Input.GetKey("r") && objeto.getPocao() >= 100) {
            objeto.setPocao();
            objeto.contador_seg = objeto.contador_seg -0.001;
            healthBar.setHealth(maxHealth);
        }
        if (FoxHealth.returnHealth() <= 0){
            anim.Play("Fox_Sit1");
        }
    }
}
