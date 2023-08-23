using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNukeController : MonoBehaviour
{
    public TextMeshProUGUI nukeCountText;
    public GameObject nukePrefab;

    private int nukeCount = 0;
    public AudioSource nukePickupSound;
    public ParticleSystem nukeExplosionParticle;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            DetonateNuke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Nuke"))
        {
            nukeCount++;
            UpdateNukeCountUI();
            if (nukePickupSound != null)
            {
                nukePickupSound.Play();
            }
            Destroy(collision.gameObject);
        }
    }

    private void UpdateNukeCountUI()
    {
        if (nukeCountText != null)
        {
            nukeCountText.text = "Nukes: " + nukeCount.ToString();
        }
    }

    private void DetonateNuke()
    {
        if (nukeCount > 0)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            foreach (var enemy in enemies)
            {
                Destroy(enemy);
            }

            nukeCount--;
            UpdateNukeCountUI();
            NukeSound.instance.PlaySound(NukeSound.instance.nukeExplosionSound);

            if (nukeExplosionParticle != null)
            {
                Instantiate(nukeExplosionParticle, transform.position, Quaternion.identity);
            }
        }
    }
}
