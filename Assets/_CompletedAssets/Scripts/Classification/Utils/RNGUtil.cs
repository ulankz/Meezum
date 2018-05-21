using System;
using System.Security.Cryptography;

static class RNGUtil
{
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="min" /> is greater than <paramref name="max" />.</exception>
	public static int Next(int min, int max)
	{
		RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
		byte[] buffer = new byte[4];
		
		rng.GetBytes(buffer);
		int result = BitConverter.ToInt32(buffer, 0);
		
		return new Random(result).Next(min, max);

	}
	private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
	
	public static int Between(int minimumValue, int maximumValue)
	{
		byte[] randomNumber = new byte[1];
		
		_generator.GetBytes(randomNumber);
		
		double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);
		
		// We are using Math.Max, and substracting 0.00000000001, 
		// to ensure "multiplier" will always be between 0.0 and .99999999999
		// Otherwise, it's possible for it to be "1", which causes problems in our rounding.
		double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);
		
		// We need to add one to the range, to allow for the rounding done with Math.Floor
		int range = maximumValue - minimumValue + 1;
		
		double randomValueInRange = Math.Floor(multiplier * range);
		
		return (int)(minimumValue + randomValueInRange);
	}
}
