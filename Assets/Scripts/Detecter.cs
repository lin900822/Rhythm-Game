using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Detecter : MonoBehaviour
{
    AudioSource musicSource;

    public SpriteRenderer sprites;

    public GameObject[] effects;

    public bool canDestroy = false;

    public KeyCode keyCodes;

    Color whiteAlphaFull;
    Color whiteAlphaHalf;

    // Start is called before the first frame update
    void Start()
    {
        musicSource = GetComponent<AudioSource>();

        sprites = GetComponent<SpriteRenderer>();

        whiteAlphaFull = Color.white;
        whiteAlphaFull.a = 0.7f;

        whiteAlphaHalf = Color.white;
        whiteAlphaHalf.a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        DetecterHandler();
    }

    void DetecterHandler()
    {
        if (Input.GetKeyDown(keyCodes))
        {
            sprites.color = whiteAlphaFull;
            canDestroy = true;
        }
        if (Input.GetKeyUp(keyCodes))
        {
            sprites.color = whiteAlphaHalf;
            canDestroy = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (canDestroy)
        {
            float timing = collision.transform.position.y - this.transform.position.y;
            if (timing < 0) timing *= -1;

            if(timing <= 0.5f)
            {
                GameController.instance.timingTxt.text = "Perfect";
                GameController.instance.timingTxt.color = Color.yellow;
                GameController.instance.gameScore += 500;
                Instantiate(effects[0], this.transform.position, this.transform.rotation);
            }
            else if(timing <= 0.7f)
            {
                GameController.instance.timingTxt.text = "Good";
                GameController.instance.timingTxt.color = Color.green;
                GameController.instance.gameScore += 300;
                Instantiate(effects[1], this.transform.position, this.transform.rotation);
            }
            else if(timing <= 0.9f)
            {
                GameController.instance.timingTxt.text = "Bad";
                GameController.instance.timingTxt.color = Color.red;
                GameController.instance.gameScore += 100;
                Instantiate(effects[2], this.transform.position, this.transform.rotation);
            }

            GameController.instance.combo++;
            musicSource.Play();
            Destroy(collision.gameObject);
        }
        
        /*
        musicSource.Play();
        Destroy(collision.gameObject);
        */
    }

}
