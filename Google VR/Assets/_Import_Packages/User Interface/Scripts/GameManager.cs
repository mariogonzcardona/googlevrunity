using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Image imgFade;

	private void Start()
	{
		Invoke("Fade",1);
	}

	private void Update()
	{
		
	}

	private void Fade()
	{
		imgFade.CrossFadeAlpha(0, 2, true);
	}
}