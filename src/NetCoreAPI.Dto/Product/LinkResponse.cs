namespace NetCoreAPI.Dto.Product
{
    public class LinkResponse
    {
        public LinkResponse(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }

        public string Href { get; set; }

        public string Rel { get; set; }

        public string Method { get; set; }
    }
}
