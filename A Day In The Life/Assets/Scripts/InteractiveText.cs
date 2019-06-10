using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveText : MonoBehaviour
{
    public Text itemInformation;
    public GameObject logBook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopInteration()
    {
        logBook.SetActive(false);
    }

    public void Interacted(string objectName)
    {
        logBook.SetActive(true);
        switch (objectName)
        {
            case "Andrew Jackson":
                itemInformation.text = "Andrew Jackson: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Ridge Party":
                itemInformation.text = "Ridge Party: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Treaty of Echota":
                itemInformation.text = "Treaty of Echota: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Indian Removal Act":
                itemInformation.text = "Indian Removal Act: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Letter To Congress":
                itemInformation.text = "Letter To Congress: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Letter of mamorial and protest":
                itemInformation.text = "Letter of mamorial and protest: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            case "Worcester v. Georgia":
                itemInformation.text = "Worcester v. Georgia: Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Etiam tempus, arcu et maximus tempor, eros orci sodales purus, vitae rhoncus ante tortor quis odio. \n\n " +
                    "Ut sit amet faucibus purus, id rhoncus mauris. Nullam nec cursus leo, eget varius lorem. " +
                    "Praesent purus ipsum, sagittis quis enim sed, pulvinar efficitur massa. " +
                    "Integer faucibus pretium lorem eu interdum. Maecenas ornare dictum eros, eget malesuada enim pharetra ut. Cras in fermentum lacus. " +
                    "Sed velit lectus, congue non nibh eu, pharetra semper risus.  ";
                break;
            default:
                throw new System.Exception("Interacable Object doesnt have a discription.");
        }
    }
}
