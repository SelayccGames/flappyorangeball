using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leadersborssd : MonoBehaviour
{
    public bool connectedGoogleplay;
    private void Awake()
    {
        
    }
    void Start()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        loginPlay();
    }
    public void loginPlay()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }
    public void showLeaderboard()
    {
        if (!connectedGoogleplay) loginPlay();

        Social.ShowLeaderboardUI();
        Debug.Log("Gösterdik Ya");
    }
     
    private void  ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
             connectedGoogleplay = true;
        }
        else connectedGoogleplay = false;
        
    }
    void Update()
    {
         
    }
}
