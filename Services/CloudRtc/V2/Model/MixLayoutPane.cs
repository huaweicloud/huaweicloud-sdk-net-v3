using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 录制视频混流参数。  用法如下：  如果某窗格需要展示某个固定用户的视频：  例如:{ \&quot;id\&quot;: 1, \&quot;user_id\&quot;: \&quot;user001\&quot;, \&quot;video_type\&quot;: \&quot;CAMERASTREAM\&quot; }  如果某窗格需要展示某个固定用户的共享屏幕：  例如:{ \&quot;id\&quot;: 1, \&quot;user_id\&quot;: \&quot;user001\&quot;, \&quot;video_type\&quot;: \&quot;SCREENSTREAM\&quot; }  如果某窗格需要展示共享桌面，不特定用户：  例如:{ \&quot;id\&quot;: 1,  \&quot;video_type\&quot;: \&quot;SCREENSTREAM\&quot;} 
    /// </summary>
    public class MixLayoutPane 
    {
        /// <summary>
        /// 标识视频流的类型，可选摄像头流或者屏幕分享流。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 
        /// </summary>
        /// <value>标识视频流的类型，可选摄像头流或者屏幕分享流。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 </value>
        [JsonConverter(typeof(EnumClassConverter<VideoTypeEnum>))]
        public class VideoTypeEnum
        {
            /// <summary>
            /// Enum CAMERASTREAM for value: CAMERASTREAM
            /// </summary>
            public static readonly VideoTypeEnum CAMERASTREAM = new VideoTypeEnum("CAMERASTREAM");

            /// <summary>
            /// Enum SCREENSTREAM for value: SCREENSTREAM
            /// </summary>
            public static readonly VideoTypeEnum SCREENSTREAM = new VideoTypeEnum("SCREENSTREAM");

            private static readonly Dictionary<string, VideoTypeEnum> StaticFields =
            new Dictionary<string, VideoTypeEnum>()
            {
                { "CAMERASTREAM", CAMERASTREAM },
                { "SCREENSTREAM", SCREENSTREAM },
            };

            private string _value;

            public VideoTypeEnum()
            {

            }

            public VideoTypeEnum(string value)
            {
                _value = value;
            }

            public static VideoTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as VideoTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoTypeEnum a, VideoTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(VideoTypeEnum a, VideoTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裁剪模式，自定义布局场景下填写本字段，支持两种模式：   - KEEP_RATIO_PADDING ：保持比例留边。   - KEEP_RATIO_CROP ：保持比例裁剪。 
        /// </summary>
        /// <value>裁剪模式，自定义布局场景下填写本字段，支持两种模式：   - KEEP_RATIO_PADDING ：保持比例留边。   - KEEP_RATIO_CROP ：保持比例裁剪。 </value>
        [JsonConverter(typeof(EnumClassConverter<CropModeEnum>))]
        public class CropModeEnum
        {
            /// <summary>
            /// Enum KEEP_RATIO_PADDING for value: KEEP_RATIO_PADDING
            /// </summary>
            public static readonly CropModeEnum KEEP_RATIO_PADDING = new CropModeEnum("KEEP_RATIO_PADDING");

            /// <summary>
            /// Enum KEEP_RATIO_CROP for value: KEEP_RATIO_CROP
            /// </summary>
            public static readonly CropModeEnum KEEP_RATIO_CROP = new CropModeEnum("KEEP_RATIO_CROP");

            private static readonly Dictionary<string, CropModeEnum> StaticFields =
            new Dictionary<string, CropModeEnum>()
            {
                { "KEEP_RATIO_PADDING", KEEP_RATIO_PADDING },
                { "KEEP_RATIO_CROP", KEEP_RATIO_CROP },
            };

            private string _value;

            public CropModeEnum()
            {

            }

            public CropModeEnum(string value)
            {
                _value = value;
            }

            public static CropModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CropModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CropModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CropModeEnum a, CropModeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CropModeEnum a, CropModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 填充策略，仅限屏幕共享模板(包括screen_share_right、screen_share_left)场景下填写本字段，支持两种模式：   - FIXED_USER ：固定用户填充。   - SHARED_SCREEN ：共享屏幕填充。 
        /// </summary>
        /// <value>填充策略，仅限屏幕共享模板(包括screen_share_right、screen_share_left)场景下填写本字段，支持两种模式：   - FIXED_USER ：固定用户填充。   - SHARED_SCREEN ：共享屏幕填充。 </value>
        [JsonConverter(typeof(EnumClassConverter<FillingPolicyEnum>))]
        public class FillingPolicyEnum
        {
            /// <summary>
            /// Enum FIXED_USER for value: FIXED_USER
            /// </summary>
            public static readonly FillingPolicyEnum FIXED_USER = new FillingPolicyEnum("FIXED_USER");

            /// <summary>
            /// Enum SHARED_SCREEN for value: SHARED_SCREEN
            /// </summary>
            public static readonly FillingPolicyEnum SHARED_SCREEN = new FillingPolicyEnum("SHARED_SCREEN");

            private static readonly Dictionary<string, FillingPolicyEnum> StaticFields =
            new Dictionary<string, FillingPolicyEnum>()
            {
                { "FIXED_USER", FIXED_USER },
                { "SHARED_SCREEN", SHARED_SCREEN },
            };

            private string _value;

            public FillingPolicyEnum()
            {

            }

            public FillingPolicyEnum(string value)
            {
                _value = value;
            }

            public static FillingPolicyEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as FillingPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FillingPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FillingPolicyEnum a, FillingPolicyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(FillingPolicyEnum a, FillingPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 窗口id，从1开始编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 加入房间的用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 标识视频流的类型，可选摄像头流或者屏幕分享流。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTypeEnum VideoType { get; set; }
        /// <summary>
        /// 坐标x，归一化百分比，画布上该画面左上角的横坐标的相对值，范围是 [0.0,1.0]。从左到右布局，0.0在最左端，1.0在最右端，小数取值范围在float内，自定义布局场景下填写本字段。
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public float? X { get; set; }

        /// <summary>
        /// 坐标y，归一化百分比，画布上该画面左上角的纵坐标的相对值，范围是 [0.0,1.0]。从上到下布局，0.0在最上端，1.0在最下端，小数取值范围在float内，自定义布局场景下填写本字段。
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public float? Y { get; set; }

        /// <summary>
        /// 窗格宽，归一化百分比，小数取值范围在float内，自定义布局场景下填写本字段。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public float? Width { get; set; }

        /// <summary>
        /// 窗格高，归一化百分比，小数取值范围在float内，自定义布局场景下填写本字段。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public float? Height { get; set; }

        /// <summary>
        /// 叠放顺序，0为最底层，1层在0层之上，以此类推，最大支持25层，自定义布局场景下填写本字段。
        /// </summary>
        [JsonProperty("zorder", NullValueHandling = NullValueHandling.Ignore)]
        public int? Zorder { get; set; }

        /// <summary>
        /// 裁剪模式，自定义布局场景下填写本字段，支持两种模式：   - KEEP_RATIO_PADDING ：保持比例留边。   - KEEP_RATIO_CROP ：保持比例裁剪。 
        /// </summary>
        [JsonProperty("crop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public CropModeEnum CropMode { get; set; }
        /// <summary>
        /// 填充策略，仅限屏幕共享模板(包括screen_share_right、screen_share_left)场景下填写本字段，支持两种模式：   - FIXED_USER ：固定用户填充。   - SHARED_SCREEN ：共享屏幕填充。 
        /// </summary>
        [JsonProperty("filling_policy", NullValueHandling = NullValueHandling.Ignore)]
        public FillingPolicyEnum FillingPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixLayoutPane {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  x: ").Append(X).Append("\n");
            sb.Append("  y: ").Append(Y).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  zorder: ").Append(Zorder).Append("\n");
            sb.Append("  cropMode: ").Append(CropMode).Append("\n");
            sb.Append("  fillingPolicy: ").Append(FillingPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixLayoutPane);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixLayoutPane input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.VideoType != input.VideoType) return false;
            if (this.X != input.X || (this.X != null && !this.X.Equals(input.X))) return false;
            if (this.Y != input.Y || (this.Y != null && !this.Y.Equals(input.Y))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Zorder != input.Zorder || (this.Zorder != null && !this.Zorder.Equals(input.Zorder))) return false;
            if (this.CropMode != input.CropMode) return false;
            if (this.FillingPolicy != input.FillingPolicy) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                if (this.X != null) hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null) hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Zorder != null) hashCode = hashCode * 59 + this.Zorder.GetHashCode();
                hashCode = hashCode * 59 + this.CropMode.GetHashCode();
                hashCode = hashCode * 59 + this.FillingPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
