using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecordContentInfoV2 
    {
        /// <summary>
        /// 录制格式flv，hls，mp4
        /// </summary>
        /// <value>录制格式flv，hls，mp4</value>
        [JsonConverter(typeof(EnumClassConverter<RecordFormatEnum>))]
        public class RecordFormatEnum
        {
            /// <summary>
            /// Enum FLV for value: FLV
            /// </summary>
            public static readonly RecordFormatEnum FLV = new RecordFormatEnum("FLV");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly RecordFormatEnum HLS = new RecordFormatEnum("HLS");

            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly RecordFormatEnum MP4 = new RecordFormatEnum("MP4");

            private static readonly Dictionary<string, RecordFormatEnum> StaticFields =
            new Dictionary<string, RecordFormatEnum>()
            {
                { "FLV", FLV },
                { "HLS", HLS },
                { "MP4", MP4 },
            };

            private string _value;

            public RecordFormatEnum()
            {

            }

            public RecordFormatEnum(string value)
            {
                _value = value;
            }

            public static RecordFormatEnum FromValue(string value)
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

                if (this.Equals(obj as RecordFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordFormatEnum a, RecordFormatEnum b)
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

            public static bool operator !=(RecordFormatEnum a, RecordFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录制类型，CONTINUOUS_RECORD，COMMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 
        /// </summary>
        /// <value>录制类型，CONTINUOUS_RECORD，COMMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 </value>
        [JsonConverter(typeof(EnumClassConverter<RecordTypeEnum>))]
        public class RecordTypeEnum
        {
            /// <summary>
            /// Enum CONTINUOUS_RECORD for value: CONTINUOUS_RECORD
            /// </summary>
            public static readonly RecordTypeEnum CONTINUOUS_RECORD = new RecordTypeEnum("CONTINUOUS_RECORD");

            /// <summary>
            /// Enum COMMAND_RECORD for value: COMMAND_RECORD
            /// </summary>
            public static readonly RecordTypeEnum COMMAND_RECORD = new RecordTypeEnum("COMMAND_RECORD");

            private static readonly Dictionary<string, RecordTypeEnum> StaticFields =
            new Dictionary<string, RecordTypeEnum>()
            {
                { "CONTINUOUS_RECORD", CONTINUOUS_RECORD },
                { "COMMAND_RECORD", COMMAND_RECORD },
            };

            private string _value;

            public RecordTypeEnum()
            {

            }

            public RecordTypeEnum(string value)
            {
                _value = value;
            }

            public static RecordTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RecordTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordTypeEnum a, RecordTypeEnum b)
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

            public static bool operator !=(RecordTypeEnum a, RecordTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播推流域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 录制文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 录制的流名
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 录制格式flv，hls，mp4
        /// </summary>
        [JsonProperty("record_format", NullValueHandling = NullValueHandling.Ignore)]
        public RecordFormatEnum RecordFormat { get; set; }
        /// <summary>
        /// 录制类型，CONTINUOUS_RECORD，COMMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecordTypeEnum RecordType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_addr", NullValueHandling = NullValueHandling.Ignore)]
        public RecordObsFileAddr ObsAddr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vod_info", NullValueHandling = NullValueHandling.Ignore)]
        public VodInfoV2 VodInfo { get; set; }

        /// <summary>
        /// OBS下载地址
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 录制开始时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间。对record_type为PLAN_RECORD有效
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 录制结束时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间。对record_type为PLAN_RECORD有效
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 该录制文件时长，单位为秒
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordContentInfoV2 {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  recordFormat: ").Append(RecordFormat).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  obsAddr: ").Append(ObsAddr).Append("\n");
            sb.Append("  vodInfo: ").Append(VodInfo).Append("\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordContentInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordContentInfoV2 input)
        {
            if (input == null) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.RecordFormat != input.RecordFormat) return false;
            if (this.RecordType != input.RecordType) return false;
            if (this.ObsAddr != input.ObsAddr || (this.ObsAddr != null && !this.ObsAddr.Equals(input.ObsAddr))) return false;
            if (this.VodInfo != input.VodInfo || (this.VodInfo != null && !this.VodInfo.Equals(input.VodInfo))) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                hashCode = hashCode * 59 + this.RecordFormat.GetHashCode();
                hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.ObsAddr != null) hashCode = hashCode * 59 + this.ObsAddr.GetHashCode();
                if (this.VodInfo != null) hashCode = hashCode * 59 + this.VodInfo.GetHashCode();
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
