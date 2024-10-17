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
    /// Response Object
    /// </summary>
    public class ShowRecordRuleResponse : SdkResponse
    {
        /// <summary>
        /// Defines recordFormats
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<RecordFormatsEnum>))]
        public class RecordFormatsEnum
        {
            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly RecordFormatsEnum HLS = new RecordFormatsEnum("HLS");

            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly RecordFormatsEnum MP4 = new RecordFormatsEnum("MP4");

            private static readonly Dictionary<string, RecordFormatsEnum> StaticFields =
            new Dictionary<string, RecordFormatsEnum>()
            {
                { "HLS", HLS },
                { "MP4", MP4 },
            };

            private string _value;

            public RecordFormatsEnum()
            {

            }

            public RecordFormatsEnum(string value)
            {
                _value = value;
            }

            public static RecordFormatsEnum FromValue(string value)
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

                if (this.Equals(obj as RecordFormatsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordFormatsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordFormatsEnum a, RecordFormatsEnum b)
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

            public static bool operator !=(RecordFormatsEnum a, RecordFormatsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 规则id，由服务端返回。创建或修改规则的时候不携带
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_addr", NullValueHandling = NullValueHandling.Ignore)]
        public RecordObsFileAddr ObsAddr { get; set; }

        /// <summary>
        /// 录制格式：HLS格式或者MP4格式
        /// </summary>
        [JsonProperty("record_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordFormatsEnum> RecordFormats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hls_config", NullValueHandling = NullValueHandling.Ignore)]
        public HLSRecordConfig HlsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mp4_config", NullValueHandling = NullValueHandling.Ignore)]
        public MP4RecordConfig Mp4Config { get; set; }

        /// <summary>
        /// 创建时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-Id", IsHeader = true)]
        [JsonProperty("X-request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordRuleResponse {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  obsAddr: ").Append(ObsAddr).Append("\n");
            sb.Append("  recordFormats: ").Append(RecordFormats).Append("\n");
            sb.Append("  hlsConfig: ").Append(HlsConfig).Append("\n");
            sb.Append("  mp4Config: ").Append(Mp4Config).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordRuleResponse input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.ObsAddr != input.ObsAddr || (this.ObsAddr != null && !this.ObsAddr.Equals(input.ObsAddr))) return false;
            if (this.RecordFormats != input.RecordFormats || (this.RecordFormats != null && input.RecordFormats != null && !this.RecordFormats.SequenceEqual(input.RecordFormats))) return false;
            if (this.HlsConfig != input.HlsConfig || (this.HlsConfig != null && !this.HlsConfig.Equals(input.HlsConfig))) return false;
            if (this.Mp4Config != input.Mp4Config || (this.Mp4Config != null && !this.Mp4Config.Equals(input.Mp4Config))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ObsAddr != null) hashCode = hashCode * 59 + this.ObsAddr.GetHashCode();
                hashCode = hashCode * 59 + this.RecordFormats.GetHashCode();
                if (this.HlsConfig != null) hashCode = hashCode * 59 + this.HlsConfig.GetHashCode();
                if (this.Mp4Config != null) hashCode = hashCode * 59 + this.Mp4Config.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
