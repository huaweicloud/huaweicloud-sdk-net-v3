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
    public class StreamTranscodingTemplate 
    {
        /// <summary>
        /// 转码流触发模式。 - play：拉流触发转码。 - publish：推流触发转码。 默认为play 
        /// </summary>
        /// <value>转码流触发模式。 - play：拉流触发转码。 - publish：推流触发转码。 默认为play </value>
        [JsonConverter(typeof(EnumClassConverter<TransTypeEnum>))]
        public class TransTypeEnum
        {
            /// <summary>
            /// Enum PLAY for value: play
            /// </summary>
            public static readonly TransTypeEnum PLAY = new TransTypeEnum("play");

            /// <summary>
            /// Enum PUBLISH for value: publish
            /// </summary>
            public static readonly TransTypeEnum PUBLISH = new TransTypeEnum("publish");

            private static readonly Dictionary<string, TransTypeEnum> StaticFields =
            new Dictionary<string, TransTypeEnum>()
            {
                { "play", PLAY },
                { "publish", PUBLISH },
            };

            private string _value;

            public TransTypeEnum()
            {

            }

            public TransTypeEnum(string value)
            {
                _value = value;
            }

            public static TransTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TransTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransTypeEnum a, TransTypeEnum b)
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

            public static bool operator !=(TransTypeEnum a, TransTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 应用名称。 默认为“live”，若您需要自定义应用名称，请先提交工单申请。 
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 转码流触发模式。 - play：拉流触发转码。 - publish：推流触发转码。 默认为play 
        /// </summary>
        [JsonProperty("trans_type", NullValueHandling = NullValueHandling.Ignore)]
        public TransTypeEnum TransType { get; set; }
        /// <summary>
        /// 视频质量信息
        /// </summary>
        [JsonProperty("quality_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityInfo> QualityInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamTranscodingTemplate {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  transType: ").Append(TransType).Append("\n");
            sb.Append("  qualityInfo: ").Append(QualityInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StreamTranscodingTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StreamTranscodingTemplate input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.TransType != input.TransType) return false;
            if (this.QualityInfo != input.QualityInfo || (this.QualityInfo != null && input.QualityInfo != null && !this.QualityInfo.SequenceEqual(input.QualityInfo))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                hashCode = hashCode * 59 + this.TransType.GetHashCode();
                if (this.QualityInfo != null) hashCode = hashCode * 59 + this.QualityInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
