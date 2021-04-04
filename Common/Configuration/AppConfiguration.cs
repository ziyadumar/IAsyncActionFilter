namespace Common.Configuration
{
    public class AppConfiguration
    {
        // public ConnectionStrings ConnectionStrings  { get; set; }  
        public string ConnectionStrings_Default  { get; set; }  
        public APIKey APIKey { get; set; }
        
        public JwtBearer JwtBearer { get; set; }
        public FileUpload FileUpload { get;set; }
        public string Environment { get; set; }
        public string BaseUrl { get; set; }
        public string ResourceBucketName { get; set; }
        
    }

    
    public class ConnectionStrings
    {
        public string Default { get; set; }
        public string Hangfire { get; set; }
    }
    
    public class APIKey
    {
        public string Scheme { get; set; }
        public string Secret { get; set; }
        public bool Enabled { get; set; }
    }

    public class JwtBearer
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Secret { get; set; }
    }
    
    
    public class FileUpload
    {
        public string Provider { get; set; }
        public string SpaceName { get; set; }
        public string SpaceContentUrl { get; set; }
        public string SpaceRegion { get; set; }
        public string SpaceAccessKey { get; set; }
        public string SpaceSecretKey { get; set; }
    }


}