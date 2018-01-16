using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour {

	public enum Language
	{
		TR,
		EN
	}

	public Language currentLanguage;

	private JSONObject data;

	public void LoadLanguage(Language language) {
		currentLanguage = language;

		string path = language.ToString();
		string languageFile = Resources.Load(path).ToString();
		
		data = new JSONObject(languageFile);
	}

	public string JSONClearify(JSONObject obj){
		return obj.ToString().Replace("\"", "");
	}

	public string GetData(string field) {
		JSONObject fieldData = data.GetField(field);
		string str = JSONClearify(fieldData);

		if(fieldData == null)
			return "";
		
		return str;
	}
}