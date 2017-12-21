using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSkillButton : MonoBehaviour {

	private GameObject content;
	private GameObject textPrefab;
	private Button getSkillButton;
	private List<string> skillList = new List<string>();

	void Awake(){
		skillList.Add ("料理");
		skillList.Add ("栽培");
		skillList.Add ("鑑定");
		skillList.Add ("園芸");
		skillList.Add ("裁縫");
		skillList.Add ("調合");
		skillList.Add ("整頓");
		skillList.Add ("彫金");
		skillList.Add ("木工");
		skillList.Add ("甲冑");
		skillList.Add ("採掘");
		skillList.Add ("精製");
		skillList.Add ("水泳");
		skillList.Add ("錬金");
		skillList.Add ("合成");
		skillList.Add ("分解");
		skillList.Add ("演奏");
		skillList.Add ("作曲");
		skillList.Add ("歌唱");
		skillList.Add ("休憩");
		Debug.Log (skillList.Count);
		content = GameObject.Find ("Content");
		textPrefab = (GameObject)Resources.Load("Prefabs/Text");
		getSkillButton = transform.GetComponent<Button> ();
	}

	void Start(){
		int max = Random.Range(1,skillList.Count - 5);
		Debug.Log (max);
//		for(int i = 0; i < Random.Range(1,(skillList.Count - 5)); i++){
		for(int i = 0; i < max; i++){
			Debug.Log(i);
			GameObject _text = Instantiate (textPrefab, content.transform);
			int index = Random.Range (0, skillList.Count);
			_text.GetComponent<Text> ().text = skillList [index];
			skillList.RemoveAt (index);
		}
	}

	public void OnClickAddSkillButton(){
		if (skillList.Count > 0) {
			GameObject _text = Instantiate (textPrefab, content.transform);
			int index = Random.Range (0, skillList.Count);
			_text.GetComponent<Text> ().text = skillList [index];
			skillList.RemoveAt (index);
			Debug.Log (skillList.Count);
		} else {
			getSkillButton.interactable = false;
			getSkillButton.GetComponentInChildren<Text> ().text = "GetAllSkill!";
			Debug.Log ("GetALLSkill!");
		}
	}
}
