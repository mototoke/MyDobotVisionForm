using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDobotVisionForm.CameraControl
{
    /// <summary>
    /// 受け渡し用オブジェクト
    /// </summary>
    public class ImageProcessValue
    {
        /// <summary>
        /// カメラ映像(処理済み)
        /// </summary>
        public Image CameraImage { get; set; }

        /// <summary>
        /// 検出オブジェクト(Blob)
        /// </summary>
        public ConnectedComponents.Blob Blob { get; set; }
    }
}
