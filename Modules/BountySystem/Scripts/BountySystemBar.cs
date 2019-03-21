using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BountySystemBar : MonoBehaviour
{
    public Sprite greyBountySprite;
    public Sprite redBountySprite;

    public Animator animator;

    private RectTransform barTemplate;
    private RectTransform imageTemplate;

    private float fillValueMax;
    private float fillValue;
    private float fillValuePerBar;

    private List<Bar> barList;

    [Range(0, 100)]
    public float fillAmount = 0f;

    // Start is called before the first frame update
    private void Awake()
    {
        barTemplate = transform.Find("BarTemplate").GetComponent<RectTransform>();
        imageTemplate = transform.Find("ImageTemplate").GetComponent<RectTransform>();

        barTemplate.gameObject.SetActive(false);
        imageTemplate.gameObject.SetActive(false);

        Setup(100f, 5);
    }

    private void Update()
    {
        SetFillValue(fillAmount);
    }

    private void Setup(float fillValueMax, int barAmount)
    {
        this.fillValueMax = fillValueMax;
        fillValue = 0f;

        fillValuePerBar = fillValueMax / barAmount;

        barList = new List<Bar>();

        for (int i = 0; i < barAmount; i++)
        {
            Vector2 barSize = new Vector2(70, 18);
            float barSizeOffset = 10f;
            Vector2 barAnchoredPosition = new Vector2((barSize.x + barSizeOffset) * i, 0);
            Bar bar = CreateBar(barAnchoredPosition, barSize);
            barList.Add(bar);
        }
    }

    private Bar CreateBar(Vector2 anchoredPosition, Vector2 size)
    {
        RectTransform barRectTransForm = Instantiate(barTemplate, transform);
        barRectTransForm.gameObject.SetActive(true);
        barRectTransForm.anchoredPosition = anchoredPosition;
        barRectTransForm.sizeDelta = new Vector2(size.x - 10f, size.y);
        barRectTransForm.SetAsFirstSibling();

         RectTransform imageRectTransform = Instantiate(imageTemplate, transform);
        imageRectTransform.gameObject.SetActive(true);
        imageRectTransform.anchoredPosition = anchoredPosition + new Vector2(0, 0);

        Bar bar = new Bar(barRectTransForm, imageRectTransform, greyBountySprite, redBountySprite);

        return bar;
    }

    private void SetFillValue(float fillValue)
    {
        this.fillValue = fillValue;

        animator = imageTemplate.GetComponent<Animator>();

        for (int i = 0; i < barList.Count; i++)
        {
            Bar bar = barList[i];

            float barValueMin = i * fillValuePerBar;
            float barValueMax = (i + 1) * fillValuePerBar;

            if(fillValue <= barValueMin)
            {
                // FILL VALUE DOES NOT REACH BAR
                bar.SetFillAmount(0f);
            }
            else if(fillValue >= barValueMax)
            {
                // FILL VALUE COMPLETLY FILLS BAR
                bar.SetFillAmount(1f);

                animator.SetBool("trigger", true);
            }
            else
            {
                float barFillAmount = (fillValue - barValueMin) / (barValueMax - barValueMin);
                bar.SetFillAmount(barFillAmount);
            }
        }
    } 

    private class Bar
    {
        private Sprite greyBountySprite;
        private Sprite redBountySprite;

        private RectTransform barRectTransForm;
        private RectTransform imageRectTransform;
        private Image barFillImage;
        private Image bountyImage;

        public Bar(RectTransform barRectTransForm, RectTransform imageRectTransform, Sprite greyBountySprite, Sprite redBountySprite)
        {
            this.barRectTransForm = barRectTransForm;
            this.imageRectTransform = imageRectTransform;
            this.greyBountySprite = greyBountySprite;
            this.redBountySprite = redBountySprite;

            barFillImage = barRectTransForm.Find("Fill").GetComponent<Image>();
            bountyImage = imageRectTransform.GetComponent<Image>();

            SetFillAmount(0f);
        }

        public void SetFillAmount(float fillAmount)
        {
            barFillImage.fillAmount = fillAmount;

            if (fillAmount >= 1f)
            {
                SetBountyRed();

            }
            else
            {
                SetBountyGrey();
            }
        }

        private void SetBountyGrey()
        {
            bountyImage.sprite = greyBountySprite;
        }

        private void SetBountyRed()
        {
            bountyImage.sprite = redBountySprite;
        }
    }
}
