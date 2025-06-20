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
    /// Response Object
    /// </summary>
    public class ShowVideoMotionCaptureJobResponse : SdkResponse
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

            public static bool operator !=(MotionCaptureModeEnum a, MotionCaptureModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务的状态。 * WAITING：等待中 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败
        /// </summary>
        /// <value>任务的状态。 * WAITING：等待中 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StateEnum WAITING = new StateEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StateEnum SUCCEED = new StateEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
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
        /// 视频驱动任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务的状态。 * WAITING：等待中 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 任务开始时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVideoMotionCaptureJobResponse {\n");
            sb.Append("  motionCaptureMode: ").Append(MotionCaptureMode).Append("\n");
            sb.Append("  inputInfo: ").Append(InputInfo).Append("\n");
            sb.Append("  outputInfo: ").Append(OutputInfo).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVideoMotionCaptureJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVideoMotionCaptureJobResponse input)
        {
            if (input == null) return false;
            if (this.MotionCaptureMode != input.MotionCaptureMode) return false;
            if (this.InputInfo != input.InputInfo || (this.InputInfo != null && !this.InputInfo.Equals(input.InputInfo))) return false;
            if (this.OutputInfo != input.OutputInfo || (this.OutputInfo != null && !this.OutputInfo.Equals(input.OutputInfo))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.State != input.State) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
