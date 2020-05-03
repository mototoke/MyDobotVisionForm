using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDobotVisionForm.Models
{
    /// <summary>
    /// 設定オブジェクト
    /// </summary>
    public class SettingsObj
    {
        /// <summary>
        /// カメラキャリブレーション用ファイルパス
        /// </summary>
        public string CalibratinFilePath { get; set; }

        /// <summary>
        /// ARマーカー左上X座標
        /// </summary>
        public double TopLeftArPoseX { get; set; }

        /// <summary>
        /// ARマーカー左上Y座標
        /// </summary>
        public double TopLeftArPoseY { get; set; }

        /// <summary>
        /// ARマーカー右上X座標
        /// </summary>
        public double TopRightArPoseX { get; set; }

        /// <summary>
        /// ARマーカー右上Y座標
        /// </summary>
        public double TopRightArPoseY { get; set; }

        /// <summary>
        /// ARマーカー右下X座標
        /// </summary>
        public double BottomRightArPoseX { get; set; }

        /// <summary>
        /// ARマーカー右下Y座標
        /// </summary>
        public double BottomRightArPoseY { get; set; }

        /// <summary>
        /// ARマーカー左下X座標
        /// </summary>
        public double BottomLeftArPoseX { get; set; }

        /// <summary>
        /// ARマーカー左下Y座標
        /// </summary>
        public double BottomLeftArPoseY { get; set; }

        /// <summary>
        /// Dobot左上X座標
        /// </summary>
        public double TopLeftDobotPoseX { get; set; }

        /// <summary>
        /// Dobot左上Y座標
        /// </summary>
        public double TopLeftDobotPoseY { get; set; }

        /// <summary>
        /// Dobot右上X座標
        /// </summary>
        public double TopRightDobotPoseX { get; set; }

        /// <summary>
        /// Dobot右上Y座標
        /// </summary>
        public double TopRightDobotPoseY { get; set; }

        /// <summary>
        /// Dobot右下X座標
        /// </summary>
        public double BottomRightDobotPoseX { get; set; }

        /// <summary>
        /// Dobot右下Y座標
        /// </summary>
        public double BottomRightDobotPoseY { get; set; }

        /// <summary>
        /// Dobot左下X座標
        /// </summary>
        public double BottomLeftDobotPoseX { get; set; }

        /// <summary>
        /// Dobot左下Y座標
        /// </summary>
        public double BottomLeftDobotPoseY { get; set; }

        /// <summary>
        /// 台座Z座標
        /// </summary>
        public double PedestalZ { get; set; }

        /// <summary>
        /// オブジェクトの高さ
        /// </summary>
        public double ObjectHeight { get; set; }

        /// <summary>
        /// 色相 最小値
        /// </summary>
        public int HueMin { get; set; }

        /// <summary>
        /// 色相 最大値
        /// </summary>
        public int HueMax { get; set; }

        /// <summary>
        /// 彩度 最小値
        /// </summary>
        public int SaturationMin { get; set; }

        /// <summary>
        /// 彩度 最大値
        /// </summary>
        public int SaturationMax { get; set; }

        /// <summary>
        /// 明度 最小値
        /// </summary>
        public int ValueMin { get; set; }

        /// <summary>
        /// 明度 最大値
        /// </summary>
        public int ValueMax { get; set; }

        /// <summary>
        /// 持っていく場所X座標
        /// </summary>
        public double PlacePoseXCoordinate { get; set; }

        /// <summary>
        /// 持っていく場所Y座標
        /// </summary>
        public double PlacePoseYCoordinate { get; set; }

        /// <summary>
        /// 持っていく場所Z座標
        /// </summary>
        public double PlacePoseZCoordinate { get; set; }
    }
}
