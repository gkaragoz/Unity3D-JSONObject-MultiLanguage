using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Button btnTurkish;
	public Button btnEnglish;
	public Text txtWelcome;
	public Text txtVersion;

	private LanguageManager languageManager;

	void Start()
	{
		languageManager = GetComponent<LanguageManager>();
		SetButtonDelegates();
		SelectLanguage(languageManager.currentLanguage);
	}

	void SetButtonDelegates() {
		btnTurkish.onClick.AddListener(delegate {
			SelectLanguage(LanguageManager.Language.TR);
		});
		btnEnglish.onClick.AddListener(delegate {
			SelectLanguage(LanguageManager.Language.EN);
		});
	}

	void SetUITexts() {
		txtWelcome.text = languageManager.GetData("txtWelcome");
		txtVersion.text = languageManager.GetData("txtVersion") + ": " + languageManager.currentLanguage;
	}

	public void SelectLanguage(LanguageManager.Language language) {
		languageManager.LoadLanguage(language);
		SetUITexts();
	}

}
