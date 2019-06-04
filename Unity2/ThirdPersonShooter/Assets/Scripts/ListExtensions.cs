using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    public static T GetRandomItem<T>(this List<T> lst)
    {
        var randomIndex = Random.Range(0, lst.Count);
        return lst[randomIndex];
    }
}