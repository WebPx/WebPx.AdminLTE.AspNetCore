using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WebPx.AdminLTE.Configuration
{
    public sealed class AdminLTEConfigureOptions : /*IPostConfigureOptions<StaticFileOptions>, */IConfigureOptions<AdminLTEOptions>
    {
        private readonly IHostingEnvironment _environment;

        public IConfiguration Configuration { get; }

        public AdminLTEConfigureOptions(IHostingEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            this.Configuration = configuration;
        }

        public void Configure(AdminLTEOptions options)
        {
            Configuration.GetSection("WebPx:Templates:AdminLTE")?.Bind(options);
        }

        //public void PostConfigure(string name, StaticFileOptions options)
        //{
        //    // Basic initialization in case the options weren't initialized by any other component
        //    options.ContentTypeProvider = options.ContentTypeProvider ?? new FileExtensionContentTypeProvider();
        //    if (options.FileProvider == null && _environment.WebRootFileProvider == null)
        //    {
        //        throw new InvalidOperationException("Missing FileProvider.");
        //    }
        //    options.FileProvider = options.FileProvider ?? _environment.WebRootFileProvider;
        //    // Add our provider
        //    var filesProvider = new ManifestEmbeddedFileProvider(GetType().Assembly, "wwwroot");
        //    options.FileProvider = new CompositeFileProvider(options.FileProvider, filesProvider);
        //}
    }
}