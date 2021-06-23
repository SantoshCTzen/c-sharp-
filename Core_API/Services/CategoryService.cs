﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Services
{
	public class CategoryService : IService<Categories, int>
	{

		private readonly CitusTrainingContext ctx;

		/// <summary>
		/// Inject the CitusTrainingContext as ctor injection in the Service class
		/// </summary>
		public CategoryService(CitusTrainingContext c)
		{
			ctx = c;
		}


		public async Task<Categories> CreateAsync(Categories entity)
		{
			var res = await ctx.Categories.AddAsync(entity);
			await ctx.SaveChangesAsync();
			return res.Entity;
		}

		public async Task<bool> DeleteAsync(int id)
		{
			var res = await ctx.Categories.FindAsync(id);
			if (res == null) return false;
			return true;
		}

		public async Task<IEnumerable<Categories>> GetAsync()
		{
			return await ctx.Categories.ToListAsync();
		}

		public async Task<Categories> GetAsync(int id)
		{
			var res = await ctx.Categories.FindAsync(id);
			return res;
		}

        public Task<Categories> Search(Categories entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Categories> UpdateAsync(int id, Categories entity)
		{
			var res = await ctx.Categories.FindAsync(id);
			if (res == null) return res;

			ctx.Entry<Categories>(entity).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			return entity;
		}
	}
}
