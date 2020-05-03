using MyDobotVisionForm.Models;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyDobotVisionForm.CameraControl
{
    /// <summary>
    /// Webカメラ制御クラス
    /// </summary>
    public class WebCameraControl
    {
        /// <summary>
        /// 終了フラグ
        /// </summary>
        public bool IsFinishFlag { get; set; } = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WebCameraControl()
        {

        }

        /// <summary>
        /// 処理実行
        /// </summary>
        public ImageProcessValue Execute(SettingsObj obj)
        {
            try
            {
                // webカメラキャプチャ
                var camera = new OpenCvSharp.VideoCapture(0)
                {
                    //// 解像度の指定
                    FrameWidth = 1920,
                    FrameHeight = 1080
                };

                using (camera)
                {
                    // カメラ内部パラメータ格納用
                    Mat mtx = new Mat();
                    Mat dist = new Mat();

                    // ymlファイルを読み来み計算パラメータを取得
                    using (var fs = new FileStorage(obj.CalibratinFilePath, FileStorage.Mode.Read))
                    {
                        mtx = fs["mtx"].ReadMat();
                        dist = fs["dist"].ReadMat();
                    }

                    var src = new Mat();

                    // 撮影画像の読み取り
                    camera.Read(src);

                    if (src.Empty()) return null;

                    Mat calib = new Mat();
                    // 歪み補正
                    Cv2.Undistort(src, calib, mtx, dist);

                    // 画像処理
                    var tmp = new Mat();
                    // OpenCVのカラーの並びに変換
                    Cv2.CvtColor(calib, tmp, OpenCvSharp.ColorConversionCodes.RGB2BGR);
                    // BGR画像をHSV画像に変換
                    var hsv = new Mat();
                    Cv2.CvtColor(tmp, hsv, OpenCvSharp.ColorConversionCodes.BGR2HSV);
                    // inRange関数で範囲指定２値化 -> マスク画像として使う
                    var msk = new Mat();
                    Cv2.InRange(hsv, new Scalar(obj.HueMin, obj.SaturationMin, obj.ValueMin), new Scalar(obj.HueMax, obj.SaturationMax, obj.ValueMax), msk);

                    // bitwise_andで元画像にマスクをかける -> マスクされた部分の色だけ残る
                    var msk_src = new Mat();
                    Cv2.BitwiseAnd(hsv, hsv, msk_src, msk);
                    var show_msk = new Mat();
                    // 元の色に戻す
                    Cv2.CvtColor(msk_src, show_msk, ColorConversionCodes.HSV2BGR);
                    // グレースケール変換
                    var gray = new Mat();
                    Cv2.CvtColor(show_msk, gray, ColorConversionCodes.BGR2GRAY);
                    // 2値化
                    var th = new Mat();
                    Cv2.Threshold(gray, th, 130, 255, ThresholdTypes.Otsu);

                    // ブロブとラベリング
                    var label = new Mat();
                    var stats = new Mat();
                    var centroids = new Mat();
                    ConnectedComponents cc = Cv2.ConnectedComponentsEx(th);

                    if (cc.LabelCount <= 1) return null;
                    // draw labels
                    //cc.RenderBlobs(show_msk);
                    // draw bonding boxes except background
                    foreach (var blob in cc.Blobs.Skip(1))
                    {
                        show_msk.Rectangle(blob.Rect, Scalar.Red);
                    }

                    // filter maximum blob
                    var maxBlob = cc.GetLargestBlob();
                    var filtered = new Mat();
                    cc.FilterByBlob(show_msk, filtered, maxBlob);

                    // 矩形探索
                    // マスク画像から矩形探索
                    Point[][] contours;
                    HierarchyIndex[] hierarchy;
                    Cv2.FindContours(th, out contours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxNone);
                    // 見つからなかったら何もしない
                    if (contours.Length == 0) return null;

                    // 回転を考慮した外接矩形
                    foreach (var cont in contours)
                    {
                        var rect = Cv2.MinAreaRect(cont);
                        var box = Cv2.BoxPoints(rect).Select(x => (Point)x);
                    }

                    Cv2.DrawContours(show_msk, contours, -1, Scalar.Yellow, 3);
                    //Cv2.ImShow("show_msk", show_msk);

                    // 画像、画像上の位置発火
                    var val = new ImageProcessValue();
                    val.CameraImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(show_msk);
                    val.Blob = maxBlob;

                    // メモリリーク対策でDispose呼ぶ
                    mtx.Dispose();
                    dist.Dispose();
                    calib.Dispose();
                    tmp.Dispose();
                    hsv.Dispose();
                    msk.Dispose();
                    msk_src.Dispose();
                    show_msk.Dispose();
                    gray.Dispose();
                    th.Dispose();
                    label.Dispose();
                    stats.Dispose();
                    centroids.Dispose();
                    filtered.Dispose();

                    return val;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*
        /// <summary>
        /// 処理実行
        /// </summary>
        public IObservable<ImageProcessValue> Execute(SettingsObj obj)
        {
            return System.Reactive.Linq.Observable.Create<ImageProcessValue>(async (IObserver<ImageProcessValue> observer, CancellationToken ct) =>
            {
                try
                {
                    // webカメラキャプチャ
                    var camera = new OpenCvSharp.VideoCapture(0)
                    {
                        //// 解像度の指定
                        FrameWidth = 1920,
                        FrameHeight = 1080
                    };

                    using (camera)
                    {
                        // カメラ内部パラメータ格納用
                        Mat mtx = new Mat();
                        Mat dist = new Mat();

                        // ymlファイルを読み来み計算パラメータを取得
                        using (var fs = new FileStorage(obj.CalibratinFilePath, FileStorage.Mode.Read))
                        {
                            mtx = fs["mtx"].ReadMat();
                            dist = fs["dist"].ReadMat();
                        }

                        // ずっとループ
                        while (true)
                        {
                            // 少し遅延させる
                            await Task.Delay(100);

                            var src = new Mat();

                            // 撮影画像の読み取り
                            camera.Read(src);

                            if (src.Empty()) break;
                            if (IsFinishFlag) break;

                            Mat calib = new Mat();
                            // 歪み補正
                            Cv2.Undistort(src, calib, mtx, dist);

                            // 画像処理
                            var tmp = new Mat();
                            // OpenCVのカラーの並びに変換
                            Cv2.CvtColor(calib, tmp, OpenCvSharp.ColorConversionCodes.RGB2BGR);
                            // BGR画像をHSV画像に変換
                            var hsv = new Mat();
                            Cv2.CvtColor(tmp, hsv, OpenCvSharp.ColorConversionCodes.BGR2HSV);
                            // inRange関数で範囲指定２値化 -> マスク画像として使う
                            var msk = new Mat();
                            Cv2.InRange(hsv, new Scalar(obj.HueMin, obj.SaturationMin, obj.ValueMin), new Scalar(obj.HueMax, obj.SaturationMax, obj.ValueMax), msk);

                            // bitwise_andで元画像にマスクをかける -> マスクされた部分の色だけ残る
                            var msk_src = new Mat();
                            Cv2.BitwiseAnd(hsv, hsv, msk_src, msk);
                            var show_msk = new Mat();
                            // 元の色に戻す
                            Cv2.CvtColor(msk_src, show_msk, ColorConversionCodes.HSV2BGR);
                            // グレースケール変換
                            var gray = new Mat();
                            Cv2.CvtColor(show_msk, gray, ColorConversionCodes.BGR2GRAY);
                            // 2値化
                            var th = new Mat();
                            Cv2.Threshold(gray, th, 130, 255, ThresholdTypes.Otsu);

                            // ブロブとラベリング
                            var label = new Mat();
                            var stats = new Mat();
                            var centroids = new Mat();
                            ConnectedComponents cc = Cv2.ConnectedComponentsEx(th);

                            if (cc.LabelCount <= 1) continue;
                            // draw labels
                            //cc.RenderBlobs(show_msk);
                            // draw bonding boxes except background
                            foreach (var blob in cc.Blobs.Skip(1))
                            {
                                show_msk.Rectangle(blob.Rect, Scalar.Red);
                            }

                            // filter maximum blob
                            var maxBlob = cc.GetLargestBlob();
                            var filtered = new Mat();
                            cc.FilterByBlob(show_msk, filtered, maxBlob);

                            // 矩形探索
                            // マスク画像から矩形探索
                            Point[][] contours;
                            HierarchyIndex[] hierarchy;
                            Cv2.FindContours(th, out contours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxNone);
                            // 見つからなかったら何もしない
                            if (contours.Length == 0) continue;

                            // 回転を考慮した外接矩形
                            foreach (var cont in contours)
                            {
                                var rect = Cv2.MinAreaRect(cont);
                                var box = Cv2.BoxPoints(rect).Select(x => (Point)x);
                            }

                            Cv2.DrawContours(show_msk, contours, -1, Scalar.Yellow, 3);
                            Cv2.ImShow("show_msk", show_msk);

                            // 画像、画像上の位置発火
                            var val = new ImageProcessValue();
                            val.CameraImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(show_msk);
                            val.Blob = maxBlob;
                            observer.OnNext(val);

                            // メモリリーク対策でDispose呼ぶ
                            mtx.Dispose();
                            dist.Dispose();
                            calib.Dispose();
                            tmp.Dispose();
                            hsv.Dispose();
                            msk.Dispose();
                            msk_src.Dispose();
                            show_msk.Dispose();
                            gray.Dispose();
                            th.Dispose();
                            label.Dispose();
                            stats.Dispose();
                            centroids.Dispose();
                            filtered.Dispose();
                        }
                        Cv2.DestroyAllWindows();
                        observer.OnCompleted();
                    }
                }
                catch (Exception e)
                {
                    observer.OnError(e);
                }
            });
        }
        */
    }
}
