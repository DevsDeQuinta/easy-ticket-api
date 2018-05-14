using System;

namespace StadiumShop.Application.Generators
{
    public static class KeyGenerator
    {
		public static string Generate()
		{
			return Guid.NewGuid().ToString();
		}
    }
}