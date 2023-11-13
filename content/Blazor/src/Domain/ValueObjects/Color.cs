// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System.Diagnostics;

using Microsoft.EntityFrameworkCore;

using Wangkanai.Domain.Common;

namespace Wangkanai.Architecture.ValueObjects;

[Owned]
public class Color : ValueObject
{
	static Color() { }
	private Color() { }
	private Color(string code) => Code = code;

	public string Code { get; private set; }

	public static Color White  => new("#FFFFFF");
	public static Color Red    => new("#FF5733");
	public static Color Orange => new("#FFC300");
	public static Color Yellow => new("#FFFF66");
	public static Color Green  => new("#CCFF99");
	public static Color Blue   => new("#6666FF");
	public static Color Purple => new("#9966CC");
	public static Color Grey   => new("#999999");

	protected static IEnumerable<Color> SupportedColors
	{
		get
		{
			yield return White;
			yield return Red;
			yield return Orange;
			yield return Yellow;
			yield return Green;
			yield return Blue;
			yield return Purple;
			yield return Grey;
		}
	}

	public static Color From(string code)
	{
		Color color = new() { Code = code };
		if (!SupportedColors.Contains(color))
			throw new UnreachableException();

		return color;
	}

	public static implicit operator string(Color color) => color.ToString();
	public static explicit operator Color(string code)  => From(code);
	public override                 string ToString()   => Code;

	protected override IEnumerable<object> GetEqualityComponents()
	{
		yield return Code;
	}
}