using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using System.Text.RegularExpressions;
using System;
public static class IntUtil
{
	private static Random random;
	
	private static void Init()
	{
		if (random == null) random = new Random(Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), @"\d+").Value));
	}
	
	public static int Random(int min, int max)
	{
		Init();
		return random.Next(min, max);
	}
}