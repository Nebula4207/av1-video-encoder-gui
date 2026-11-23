namespace av1-video-encoder-gui.Queue
{
    public class ChunkProgress
    {
        public string ChunkName { get; set; }
        public long Progress { get; set; } = 0;
        public long ProgressSecondPass { get; set; } = 0;
    }
}
