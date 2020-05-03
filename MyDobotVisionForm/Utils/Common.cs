using HomographySharp.Double;
using MathNet.Numerics.LinearAlgebra.Double;
using MyDobotVisionForm.Models;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDobotVisionForm.Utils
{
    /// <summary>
    /// メッセージタイプ
    /// </summary>
    public enum MsgInfoType
    {
        Info,
        Error,
        Warnning
    }

    /// <summary>
    /// Utility Methods Class
    /// </summary>
    public static class Methods
    {
        /// <summary>
        /// 対象物の位置をロボット座標系で取得します。
        /// </summary>
        /// <param name="blob"></param>
        /// <returns></returns>
        public static (double x, double y) GetTargetRobotCoordinate(SettingsObj obj, ConnectedComponents.Blob blob)
        {
            var srcList = new List<DenseVector>(4);
            var dstList = new List<DenseVector>(4);
            // 各座標系の4点をリストに詰める
            srcList.Add(DenseVector.OfArray(new double[] { obj.TopLeftArPoseX, obj.TopLeftArPoseY }));
            srcList.Add(DenseVector.OfArray(new double[] { obj.TopRightArPoseX, obj.TopRightArPoseY }));
            srcList.Add(DenseVector.OfArray(new double[] { obj.BottomRightArPoseX, obj.BottomRightArPoseY }));
            srcList.Add(DenseVector.OfArray(new double[] { obj.BottomLeftArPoseX, obj.BottomLeftArPoseY }));
            dstList.Add((HomographyHelper.CreateVector2(obj.TopLeftDobotPoseX, obj.TopLeftDobotPoseY)));
            dstList.Add(HomographyHelper.CreateVector2(obj.TopRightDobotPoseX, obj.TopRightDobotPoseY));
            dstList.Add(HomographyHelper.CreateVector2(obj.BottomRightDobotPoseX, obj.BottomRightDobotPoseY));
            dstList.Add(HomographyHelper.CreateVector2(obj.BottomLeftDobotPoseX, obj.BottomLeftDobotPoseY));

            // 画像座標系での値
            Console.WriteLine($"homography_IMAGE:imgX:{blob.Left + blob.Width / 2}, imgY:{blob.Top + blob.Height / 2}");
            // 射影変換行列を求めて
            var homo = HomographyHelper.FindHomography(srcList, dstList);

            // 入力平面から出力平面上の座標に変換
            var ret = homo.Translate(blob.Left + blob.Width / 2, blob.Top + blob.Height / 2);
            // ロボット座標系での値
            Console.WriteLine($"homography_ROBOT:boxX:{ret.dstX}, boxY:{ret.dstY}");

            return ret;
        }
    }
}
