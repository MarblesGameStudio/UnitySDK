using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class JavascriptInterop : MonoBehaviour
{
	// Start is called before the first frame update
	
	[DllImport("__Internal")]
	public static extern void Purchase(string productId);

	[DllImport("__Internal")]
	public static extern void FetchNFTs(string collectionAddress);	


	private static JavascriptInterop _instance;

	public static JavascriptInterop Instance
	{
		get
		{
			if (_instance == null)
			{
				var obj = new GameObject("JavascriptInterop");
				_instance = obj.AddComponent<JavascriptInterop>();
				DontDestroyOnLoad(obj);
			}

			return _instance;
		}
	}

	private void OnPurchaseCompleted(string productId){

	}

	private void OnPurchaseFailed(string productId){

	}

	
}
