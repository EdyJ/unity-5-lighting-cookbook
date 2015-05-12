using UnityEngine;
using System.Collections;

public class ColorCycler : MonoBehaviour
	{
	[Range(0,1)]
	public float rate = 0.1f;

	Renderer m_renderer;
	float m_t = 0.0f;


	// Use this for initialization
	void OnEnable ()
		{
		m_renderer = GetComponent<Renderer>();
		}


	// Update is called once per frame
	void Update ()
		{
		m_t += Time.deltaTime * rate;
		Color col = new Color(m_t % 2.0f, (m_t*2) % 2.0f, (m_t*0.5f) % 2.0f, 1.0f);

		// DynamicGI.SetEmissive(m_renderer, col);

		m_renderer.sharedMaterial.SetColor("_EmissionColor", col);
		DynamicGI.UpdateMaterials(m_renderer);
		}
	}
