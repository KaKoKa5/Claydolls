using UnityEngine;

public class TableauMemoire : MonoBehaviour
{
    //Identification de qu'elle masque on a. Relier à MaskCyclerUI.cs
    public static int masque = 0;
    
    //Premiere mission : Parler à tout le monde. 
    //Pour continuer il faut que le bool de chaque animal est "true"
    public static bool talkCochon = false;
    public static bool talkCorbeau = false; 
    public static bool talkSerpent = false; 
    public static bool talkChien = false; 
    public static bool talkCerf= false; // A mettre en false pour jouer pour de vrai  
    public static bool talkBrebis = false; 
    //Fin de mission, faut donc aller parler au CERF.

    // Deuxième mission : 
    public static bool confidenceCerf = false; // A mettre en false pour jouer pour de vrai  

    //Troisième,Quatrième Mission , avec le masque du loup il faudra sympathisé avec le chien. Grace à ça le Corbeau nous donnera un secret sur le cerf
    public static bool MLoupFound=false;
    public static bool AmiChien = false;
    public static bool SecretSurCerf= false;

    //Mission ??? Après avoir trouvé le masque du Lion:
    public static bool MLionFound=false;

    public static bool CochonHagrad = false ;
    

}