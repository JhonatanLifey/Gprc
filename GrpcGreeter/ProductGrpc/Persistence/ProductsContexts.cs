using Microsoft.EntityFrameworkCore;
using ProductGrpc.Models;

namespace ProductGrpc.Persistence
{
	public class ProductsContexts : DbContext
	{
		public ProductsContexts(DbContextOptions<ProductsContexts> options)
			: base(options)
		{

		}


		public DbSet<Products> Products {get; set;}


	}
}
