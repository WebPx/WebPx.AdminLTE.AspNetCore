namespace WebPx.AdminLTE.Configuration
{
    public sealed class AdminLTEStaticsConfigureOptions : IPostConfigureOptions<StaticFileOptions>
    {
        private readonly IHostingEnvironment _environment;

        public IConfiguration Configuration { get; }

        public AdminLTEStaticsConfigureOptions(IHostingEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            this.Configuration = configuration;
        }

        public void PostConfigure(string name, StaticFileOptions options)
        {
            // Basic initialization in case the options weren't initialized by any other component
            options.ContentTypeProvider = options.ContentTypeProvider ?? new FileExtensionContentTypeProvider();
            if (options.FileProvider == null && _environment.WebRootFileProvider == null)
            {
                throw new InvalidOperationException("Missing FileProvider.");
            }
            options.FileProvider = options.FileProvider ?? _environment.WebRootFileProvider;
            // Add our provider
            var filesProvider = new ManifestEmbeddedFileProvider(GetType().Assembly, "wwwroot");
            options.FileProvider = new CompositeFileProvider(options.FileProvider, filesProvider);
        }

    }
}
