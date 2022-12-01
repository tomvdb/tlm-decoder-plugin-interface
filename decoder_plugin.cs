using System.Collections;

namespace TLMSuite.decoder
{
    public interface IPlugin
    {
        int NoradID { get;  }
        int Version { get; }
        string Name { get; }
        string Author { get; }
        string Description { get; }

        public Hashtable parseFrame(byte[] frame);
    }
}