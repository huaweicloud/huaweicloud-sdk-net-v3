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
    /// 数字人制作任务信息。
    /// </summary>
    public class DigitalHumanVideo 
    {
        /// <summary>
        /// 任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结
        /// </summary>
        /// <value>任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结</value>
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

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StateEnum CANCELED = new StateEnum("CANCELED");

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            public static readonly StateEnum BLOCK = new StateEnum("BLOCK");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
                { "BLOCK", BLOCK },
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
        /// 任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务
        /// </summary>
        /// <value>任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum _2D_DIGITAL_HUMAN_VIDEO for value: 2D_DIGITAL_HUMAN_VIDEO
            /// </summary>
            public static readonly JobTypeEnum _2D_DIGITAL_HUMAN_VIDEO = new JobTypeEnum("2D_DIGITAL_HUMAN_VIDEO");

            /// <summary>
            /// Enum DIGITAL_HUMAN_PHOTO_VIDEO for value: DIGITAL_HUMAN_PHOTO_VIDEO
            /// </summary>
            public static readonly JobTypeEnum DIGITAL_HUMAN_PHOTO_VIDEO = new JobTypeEnum("DIGITAL_HUMAN_PHOTO_VIDEO");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "2D_DIGITAL_HUMAN_VIDEO", _2D_DIGITAL_HUMAN_VIDEO },
                { "DIGITAL_HUMAN_PHOTO_VIDEO", DIGITAL_HUMAN_PHOTO_VIDEO },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
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

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
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

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// 数字人视频制作开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数字人视频制作结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 数字人视频内容时长。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_asset_config", NullValueHandling = NullValueHandling.Ignore)]
        public OutputAssetInfo OutputAssetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务更新时间。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastupdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalHumanVideo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  outputAssetConfig: ").Append(OutputAssetConfig).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DigitalHumanVideo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DigitalHumanVideo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.State != input.State) return false;
            if (this.JobType != input.JobType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.OutputAssetConfig != input.OutputAssetConfig || (this.OutputAssetConfig != null && !this.OutputAssetConfig.Equals(input.OutputAssetConfig))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.OutputAssetConfig != null) hashCode = hashCode * 59 + this.OutputAssetConfig.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
