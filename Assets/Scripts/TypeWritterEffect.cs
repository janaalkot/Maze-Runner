using UnityEngine;
using TMPro;
using System.Collections;

public class TypeWritterEffect : MonoBehaviour
{

    public TextMeshProUGUI _text;

    public string[] stringarr;

    public float timeBtwnChars;
    public float timeBtwnWords;

    int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EndCheck();
    }

    void EndCheck () 
    {
        if(i <= stringarr.Length - 1)
        {
            _text.text = stringarr[i];
            StartCoroutine(TextVisible());
        }
    }

    private IEnumerator TextVisible()
    {
        _text.ForceMeshUpdate();
        int totalVisibaleCharacter = _text.textInfo.characterCount;
        int count =0;

        while (true)
        {
            int visibleCount = count% (totalVisibaleCharacter + 1);
            _text.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibaleCharacter)
            {
                i++;
                Invoke("EndCheck", timeBtwnWords);
                break;
            }
            count ++;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }
}
