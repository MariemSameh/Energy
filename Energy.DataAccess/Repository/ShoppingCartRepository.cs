﻿using Energy.DataAccess.Data;
using Energy.DataAccess.Repository.IRepository;
using Energy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy.DataAccess.Repository
{
	public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
	{
		private ApplicationDbContext _db;

		public ShoppingCartRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public int DecrementCount(ShoppingCart shoppingCart, int count)
		{
			shoppingCart.Count -= count;
			return shoppingCart.Count;
		}

		public int IncrementCount(ShoppingCart shoppingCart, int count)
		{
			shoppingCart.Count += count;
			return shoppingCart.Count;
		}
	}
}