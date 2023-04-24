using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conventions : MonoBehaviour
{
    #region Declarations

    // For a region with sub-regions, leave a blank line between each entry, and it should only have regions in it.
    // And an expository comment at the top (the line 9 one, pretend line 10 doesn't exist)

    #region General
    // Variables will be set private in the majority of cases
    [Header ("General Variables")] // Header to region the inspector
    [SerializeField] // If you need it to appear in the inspector
    private int numCrapsIGive; // Never initialize variables outside of methods
                               // Use descriptive naming, and avoid using var unless absolutely necessary
    #endregion

    #region HighCrapsCount
    [Header ("HighCrapsCountVariables")]
    [Tooltip("[Tooltip (\"\")] will give info about a variable when you hover over it in the inspector.")]
    [SerializeField]
    private Vector2 vectorFromAroundLine120;
    #endregion

    #endregion

    #region Initializations
    // Contains Start and Awake

    // Awake is, in short, called just before start
    private void Awake()
    {
        // Initialize independent variables
        // Initialize anything that other variables depend on for initialization
    }
    // End Awake

    // Start is called before the first frame update
    void Start()
    {
        // Initialize anything that depends on other variables for its initialization
    }
    // End Start
    #endregion

    #region Update
    //Update always gets a region, so we can collapse the top chunk of every file and just look at the uncommons if we want

    // Update is called once per frame
    void Update()
    {
        // Update should be very bare; in the same way an FSM's update is just "Reason(); \n Act();", try to break code into components - doing this will also facilitate using regions for navigability.
        // Here's an example:
        Reason();
        Act();
    }
    // End Update
    #endregion

    #region Reason_Methods

    #region Parent
    // Reason will determine if the number of craps we SHOULD be giving is the number we are giving, and adjust accordingly
    void Reason()
    {
        // [Insert Reason() code here]
    }
    // End Reason
    #endregion

    #endregion

    #region Act_Methods

    /*
    Since Act() is longer than other methods, and has submethods, I made a region so we can collapse it and its paratext.
    Feel welcome to region smaller sections as well, but mainly, if it's larger than 20 lines,
    start to consider regioning it if you weren't already.
    And I'm gonna make this a block comment since I'm talking about the same thing accross
    many lines.
    */

    #region Parent
    // Act will perform behaviours based on the current number of craps given
    void Act()
    {
        if (numCrapsIGive > 5) HighCrapsCount(); // In-Line Ifs are preferred
        else if (numCrapsIGive > 3)
            MediumCrapsCount(); // Hanging Line Ifs are also acceptable, especially in cases of a long if
        else if(numCrapsIGive>0)
        {
            LowCrapsCount(); //this is all kinds of wrong
            //there was only one instruction, so the brackets are unnecessary
            //no space or capitalization after the comment header //
            //the if doesn't have any spaces
            //and this should be a block comment by now
        }
    }
    // End Act
    #endregion


    #region HighCrapsCount
    // HighCrapsCount won't do anything related to this faux program.
    // I'll instead use it to talk about the rules I give the most craps about.
    public Vector2 globalVectorForJustThisFile;
    /*
    2 Problems:
        1   It shouldn't be public unless another file needs to use it
        2   If it's global, and pertains to multiple sections of the code,
            declare it at the top in the general declarations.
            If it only pertains to this area of the code, declare it in region
            declarations.
    */
    void HighCrapsCount()
    {
        /*
        I care most about:
            Unity DOTS where possible
            Readable comment structure
            Regions
            Proper variable naming (Networked elements are probably gonna be n_variableName, I'm open to suggestions)
            Proper file naming - working system is:
                sys_fileName - a system in the game (I can't think of any examples)
                mng_fileName - a manager like mng_pauseUIManager
                ctrl_fileName - a controller like ctrl_playerController or ctrl_bodyController
                n_PREFIX_fileName - a networked version of a filename
            [SerializeField] instead of publics, and [HideInInspector] for something that must be public but doesn't need to clutter the inspector
            [Header]s and [Tooltip]s to create very navigable inspectors
            Variables ending up in the wrong area because people put them near the method using them the most
            Stuff like:
                while(true)
                    int a = 0; // why are we creating and garbaging an int every loop iteration
            Region label comments (like line 106)
            Subfolders in the scripts folder - please put all player-pertaining scripts in Scripts > Player and etc for others
        */

    }
    //End HighCrapsCount
    #endregion

    #region MediumCrapsCount
    //Medium will address semi serious things. Try to uphold them, I will enforce them if it gets bad.
    void MediumCrapsCount()
    {
        /*
        I care less about the neatness of ifs, but I prefer the linecount kept low when possible
        I don't really need a comment AND a tooltip on a serialized variable, just a tooltip is fine but both is nice
        Try to break things up into multiple files where it is logical to do so
            It's a lot easier to debug one of seven 100 line files than to debug one 700 line file
            Audio management for the sounds the player makes could probably be separated out fairly easily
            Don't take this too far though - if we don't end up separating a lot out, not a big deal
        */
    }
    #endregion

    #region LowCrapsCount
    //Low will cover stuff I really won't bother enforcing, but please do them
    void LowCrapsCount()
    {
        /*
        I don't particularly CARE per se if you use a different commenting structure than I do, so long as it's readable
            I'd prefer if you follow the style laid out in this doc though
        Try to point the designers to YouTube, or, if you're fixing something for them, try to help them understand how the fix works
            it's in their best interests to learn to navigate unity better
        */

    }
    #endregion

    #endregion

}
