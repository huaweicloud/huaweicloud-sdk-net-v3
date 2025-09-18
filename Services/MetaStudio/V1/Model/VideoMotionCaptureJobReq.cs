using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 视频驱动动作任务请求。
    /// </summary>
    public class VideoMotionCaptureJobReq 
    {
        /// <summary>
        /// 视频驱动模式。 * HEAD：头部 * HALF_BODY：半身 * FULL_BODY：全身 * AUTO：自动
        /// </summary>
        /// <value>视频驱动模式。 * HEAD：头部 * HALF_BODY：半身 * FULL_BODY：全身 * AUTO：自动</value>
        [JsonConverter(typeof(EnumClassConverter<MotionCaptureModeEnum>))]
        public class MotionCaptureModeEnum
        {
            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            public static readonly MotionCaptureModeEnum HEAD = new MotionCaptureModeEnum("HEAD");

            /// <summary>
            /// Enum HALF_BODY for value: HALF_BODY
            /// </summary>
            public static readonly MotionCaptureModeEnum HALF_BODY = new MotionCaptureModeEnum("HALF_BODY");

            /// <summary>
            /// Enum FULL_BODY for value: FULL_BODY
            /// </summary>
            public static readonly MotionCaptureModeEnum FULL_BODY = new MotionCaptureModeEnum("FULL_BODY");

            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly MotionCaptureModeEnum AUTO = new MotionCaptureModeEnum("AUTO");

            private static readonly Dictionary<string, MotionCaptureModeEnum> StaticFields =
            new Dictionary<string, MotionCaptureModeEnum>()
            {
                { "HEAD", HEAD },
                { "HALF_BODY", HALF_BODY },
                { "FULL_BODY", FULL_BODY },
                { "AUTO", AUTO },
            };

            private string _value;

            public MotionCaptureModeEnum()
            {

            }

            public MotionCaptureModeEnum(string value)
            {
                _value = value;
            }

            public static MotionCaptureModeEnum FromValue(string value)
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

                if (this.Equals(obj as MotionCaptureModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MotionCaptureModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MotionCaptureModeEnum a, MotionCaptureModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(MotionCaptureModeEnum a, MotionCaptureModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视频驱动模式。 * HEAD：头部 * HALF_BODY：半身 * FULL_BODY：全身 * AUTO：自动
        /// </summary>
        [JsonProperty("motion_capture_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MotionCaptureModeEnum MotionCaptureMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input_info", NullValueHandling = NullValueHandling.Ignore)]
        public InputInfo InputInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_info", NullValueHandling = NullValueHandling.Ignore)]
        public OutputInfo OutputInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMotionCaptureJobReq {\n");
            sb.Append("  motionCaptureMode: ").Append(MotionCaptureMode).Append("\n");
            sb.Append("  inputInfo: ").Append(InputInfo).Append("\n");
            sb.Append("  outputInfo: ").Append(OutputInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoMotionCaptureJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoMotionCaptureJobReq input)
        {
            if (input == null) return false;
            if (this.MotionCaptureMode != input.MotionCaptureMode) return false;
            if (this.InputInfo != input.InputInfo || (this.InputInfo != null && !this.InputInfo.Equals(input.InputInfo))) return false;
            if (this.OutputInfo != input.OutputInfo || (this.OutputInfo != null && !this.OutputInfo.Equals(input.OutputInfo))) return false;

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
                hashCode = hashCode * 59 + this.MotionCaptureMode.GetHashCode();
                if (this.InputInfo != null) hashCode = hashCode * 59 + this.InputInfo.GetHashCode();
                if (this.OutputInfo != null) hashCode = hashCode * 59 + this.OutputInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
