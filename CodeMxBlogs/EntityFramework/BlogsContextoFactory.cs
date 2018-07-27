using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CodeMxBlogsCore.EntityFramework
{
    /// <summary>
    /// Clase que se implementa para que desacople EF de un proyecto
    /// </summary>
    public class BlogsContextoFactory: IDesignTimeDbContextFactory<BlogsContexto>
    {
        public BlogsContexto CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<BlogsContexto>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString(args?.Length >= 1? args[0] : "BlogsConnection"));
            return new BlogsContexto(optionsBuilder.Options);
        }

        public BlogsContexto CreateDbContext()
        {
            return CreateDbContext(new []{ "BlogsConnection"});
        }
    }
}
