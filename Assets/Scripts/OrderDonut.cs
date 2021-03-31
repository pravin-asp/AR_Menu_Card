using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderDonut : MonoBehaviour {

	AndroidJavaObject currentActivity;

    public void Send(string phone)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            RunAndroidUiThread();
        }
    }

    void RunAndroidUiThread()
    {
        AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(SendProcess));
    }

    void SendProcess()
    {
        Debug.Log("Running on UI thread");
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        
        // SMS Information
        string dish = "Donut";
        string phone1 = "8610373818";
		string phone2 = "9751258582";
		string phone3 = "9566661670";
        string cook = "Table 01\n Ordered : " + dish;
		string waiter = "Deliver the "+ dish +" in Table 01";
		string cashier = dish + " \nOrdered in Table 01 ";
        string alert;

        try
        {
            // SMS Manager

            AndroidJavaClass SMSManagerClass = new AndroidJavaClass("android.telephony.SmsManager");
            AndroidJavaObject SMSManagerObject = SMSManagerClass.CallStatic<AndroidJavaObject>("getDefault");
            SMSManagerObject.Call("sendTextMessage", phone1, null, cook, null, null);
			SMSManagerObject.Call("sendTextMessage", phone2, null, waiter, null, null);
			SMSManagerObject.Call("sendTextMessage", phone3, null, cashier, null, null);

            alert = "Ordered Successfully\nWill be delivered in 2 - 3 minutes\nHave your delicious food. Thank you!!!";
        }
        catch (System.Exception e)
        {
            Debug.Log("Error : " + e.StackTrace.ToString());

            alert = "Error has been Occurred in the system. Failed to Order the dish.";
        }

        // Show Toast

        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", alert);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
        toast.Call("show");
    }
}
