using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(KeyBehaviour))]
public class KeyBehaviourEditor : Editor
{
    //fazer editor de um monobehaviour que contem uma tabela. cada linha deve conter a chave e o valor lado a lado
    //essa tabela é um List<Entry> Entry { string key; int value; }
    //extras: fazer botao de adicionar elemento e fazer botao de remover elemento 

    int remove;

    public override void OnInspectorGUI()
    {
        KeyBehaviour keyBehaviour = target as KeyBehaviour;
        remove = -1;

        EditorGUILayout.LabelField("List", EditorStyles.whiteLargeLabel);

        foreach (KeyBehaviour.Entry i in keyBehaviour.listEntry)
        {
            EditorGUILayout.BeginHorizontal();
            i.key = EditorGUILayout.TextField(i.key);
            i.value = EditorGUILayout.IntField(i.value);
            if (GUILayout.Button("remove"))
            {
                remove = keyBehaviour.listEntry.IndexOf(i);
            }
            EditorGUILayout.EndHorizontal();
        }

        if(GUILayout.Button("ADD"))
        {
            keyBehaviour.listEntry.Add(new KeyBehaviour.Entry());
        }
        if(remove >= 0)
        {
            keyBehaviour.listEntry.RemoveAt(remove);
        }
    }
}
