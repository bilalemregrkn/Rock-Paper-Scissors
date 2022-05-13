using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create ElementController", fileName = "ElementController", order = 0)]
public class ElementController : ScriptableObject
{
	public Sprite MySprite;
	public ElementType MyType;

	public List<ElementType> WeakTypes;
}