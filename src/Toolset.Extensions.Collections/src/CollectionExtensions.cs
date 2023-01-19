[assembly: CLSCompliant(true)]
namespace Toolset.Extensions.Collections;

[CLSCompliant(true)]
public static class CollectionExtensions
{
	private static readonly Random Random = new ();
	
	/// <summary>
	/// Shuffles list using Fisher-Yates shuffle algorithm. Keep in mind that Fisher-Yates shuffle algorithm
	/// do not guarantees that no element will stay in its original position.
	/// </summary>
	/// <param name="list">Original list that will be shuffled.</param>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	public static void Shuffle<T>(this IList<T> list)
	{
		var n = list.Count;
		while (n > 1)
		{
			n--;
			var k = Random.Next(n + 1);
			(list[k], list[n]) = (list[n], list[k]);
		}
	}

	/// <summary>
	/// Shuffles array using Fisher-Yates shuffle algorithm. Keep in mind that Fisher-Yates shuffle algorithm
	/// do not guarantees that no element will stay in its original position.
	/// </summary>
	/// <param name="array">Original array that will be shuffled.</param>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	public static void Shuffle<T>(this T[] array)
	{
		var n = array.Length;
		while (n > 1)
		{
			n--;
			var k = Random.Next(n + 1);
			(array[k], array[n]) = (array[n], array[k]);
		}
	}
}
