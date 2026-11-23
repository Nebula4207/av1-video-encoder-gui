using System.Collections.Generic;
using System.Windows.Documents;

namespace av1-video-encoder-gui.Queue
{
    public class ChunkVMAF
    {
        public string ChunkName { get; set; }
        public string CalculatedQuantizer { get; set; }
        public List<double> QValues { get; set; }
        public List<double> VMAFValues { get; set; }
    }
}
