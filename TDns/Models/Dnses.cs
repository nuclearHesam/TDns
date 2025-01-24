namespace TDns
{
    public class Dns
    {
        public string Name { get; set; } = default!;
        public byte[] Image { get; set; } = default!;
        //  Preferred Dns Server
        public string Pds { get; set; } = default!;
        //  Alternate Dns Server
        public string Ads { get; set; } = default!;

        public string Link { get; set; } = default!;
    }
}
