using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKCameraDemo
{
    /// <summary>
    /// 帧类型定义
    /// </summary>
    public enum VideoType
    {
        Unknown = 0,
        AUDIO16 = 1,
        RGB32 = 2,
        YV12 = 3,
        UYVY = 4,
        YUV420 = 5,
        YUY2 = 6,
        AUDIO8 = 7,

        RGB24 = 9,
        GRAY = 10,

        RGB555 = 11,
        RGB565 = 12,
        YUV422 = 13,
        YUV444 = 14
    }

    /// <summary>
    /// 缓冲视频数据
    /// </summary>
    public class FrameData
    {
        /// <summary>
        /// 缓冲取到的视频帧
        /// </summary>
        public byte[] FrameBuffer
        {
            get;
            set;
        }

        /// <summary>
        /// 每帧大小
        /// </summary>
        public int FrameSize
        {
            get;
            set;
        }

        /// <summary>
        /// 总帧数
        /// </summary>
        public int Frames
        {
            get;
            set;
        }

        /// <summary>
        /// 每帧宽度
        /// </summary>
        public int FrameWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 每帧高度
        /// </summary>
        public int FrameHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 帧类型
        /// </summary>
        public VideoType Type
        {
            get;
            set;
        }
    }

}
