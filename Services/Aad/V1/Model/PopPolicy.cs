using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 策略阈值详情
    /// </summary>
    public class PopPolicy 
    {
        /// <summary>
        /// 固定值ALL
        /// </summary>
        /// <value>固定值ALL</value>
        [JsonConverter(typeof(EnumClassConverter<PopEnum>))]
        public class PopEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly PopEnum ALL = new PopEnum("ALL");

            private static readonly Dictionary<string, PopEnum> StaticFields =
            new Dictionary<string, PopEnum>()
            {
                { "ALL", ALL },
            };

            private string _value;

            public PopEnum()
            {

            }

            public PopEnum(string value)
            {
                _value = value;
            }

            public static PopEnum FromValue(string value)
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

                if (this.Equals(obj as PopEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PopEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PopEnum a, PopEnum b)
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

            public static bool operator !=(PopEnum a, PopEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 位置封禁列表
        /// </summary>
        [JsonProperty("block_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlockLocation { get; set; }

        /// <summary>
        /// 协议封禁列表
        /// </summary>
        [JsonProperty("block_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlockProtocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bw_list", NullValueHandling = NullValueHandling.Ignore)]
        public Bw BwList { get; set; }

        /// <summary>
        /// 是否开启连接防护
        /// </summary>
        [JsonProperty("connection_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectionProtection { get; set; }

        /// <summary>
        /// 连接防护列表
        /// </summary>
        [JsonProperty("connection_protection_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConnectionProtectionList { get; set; }

        /// <summary>
        /// 指纹数
        /// </summary>
        [JsonProperty("fingerprint_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FingerprintCount { get; set; }

        /// <summary>
        /// 端口封禁数
        /// </summary>
        [JsonProperty("port_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortBlockCount { get; set; }

        /// <summary>
        /// 水印数
        /// </summary>
        [JsonProperty("watermark_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WatermarkCount { get; set; }

        /// <summary>
        /// 是否存在流量
        /// </summary>
        [JsonProperty("if_exist_traffic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IfExistTraffic { get; set; }

        /// <summary>
        /// 固定值ALL
        /// </summary>
        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        public PopEnum Pop { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PopPolicy {\n");
            sb.Append("  blockLocation: ").Append(BlockLocation).Append("\n");
            sb.Append("  blockProtocol: ").Append(BlockProtocol).Append("\n");
            sb.Append("  bwList: ").Append(BwList).Append("\n");
            sb.Append("  connectionProtection: ").Append(ConnectionProtection).Append("\n");
            sb.Append("  connectionProtectionList: ").Append(ConnectionProtectionList).Append("\n");
            sb.Append("  fingerprintCount: ").Append(FingerprintCount).Append("\n");
            sb.Append("  portBlockCount: ").Append(PortBlockCount).Append("\n");
            sb.Append("  watermarkCount: ").Append(WatermarkCount).Append("\n");
            sb.Append("  ifExistTraffic: ").Append(IfExistTraffic).Append("\n");
            sb.Append("  pop: ").Append(Pop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PopPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PopPolicy input)
        {
            if (input == null) return false;
            if (this.BlockLocation != input.BlockLocation || (this.BlockLocation != null && input.BlockLocation != null && !this.BlockLocation.SequenceEqual(input.BlockLocation))) return false;
            if (this.BlockProtocol != input.BlockProtocol || (this.BlockProtocol != null && input.BlockProtocol != null && !this.BlockProtocol.SequenceEqual(input.BlockProtocol))) return false;
            if (this.BwList != input.BwList || (this.BwList != null && !this.BwList.Equals(input.BwList))) return false;
            if (this.ConnectionProtection != input.ConnectionProtection || (this.ConnectionProtection != null && !this.ConnectionProtection.Equals(input.ConnectionProtection))) return false;
            if (this.ConnectionProtectionList != input.ConnectionProtectionList || (this.ConnectionProtectionList != null && input.ConnectionProtectionList != null && !this.ConnectionProtectionList.SequenceEqual(input.ConnectionProtectionList))) return false;
            if (this.FingerprintCount != input.FingerprintCount || (this.FingerprintCount != null && !this.FingerprintCount.Equals(input.FingerprintCount))) return false;
            if (this.PortBlockCount != input.PortBlockCount || (this.PortBlockCount != null && !this.PortBlockCount.Equals(input.PortBlockCount))) return false;
            if (this.WatermarkCount != input.WatermarkCount || (this.WatermarkCount != null && !this.WatermarkCount.Equals(input.WatermarkCount))) return false;
            if (this.IfExistTraffic != input.IfExistTraffic || (this.IfExistTraffic != null && !this.IfExistTraffic.Equals(input.IfExistTraffic))) return false;
            if (this.Pop != input.Pop) return false;

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
                if (this.BlockLocation != null) hashCode = hashCode * 59 + this.BlockLocation.GetHashCode();
                if (this.BlockProtocol != null) hashCode = hashCode * 59 + this.BlockProtocol.GetHashCode();
                if (this.BwList != null) hashCode = hashCode * 59 + this.BwList.GetHashCode();
                if (this.ConnectionProtection != null) hashCode = hashCode * 59 + this.ConnectionProtection.GetHashCode();
                if (this.ConnectionProtectionList != null) hashCode = hashCode * 59 + this.ConnectionProtectionList.GetHashCode();
                if (this.FingerprintCount != null) hashCode = hashCode * 59 + this.FingerprintCount.GetHashCode();
                if (this.PortBlockCount != null) hashCode = hashCode * 59 + this.PortBlockCount.GetHashCode();
                if (this.WatermarkCount != null) hashCode = hashCode * 59 + this.WatermarkCount.GetHashCode();
                if (this.IfExistTraffic != null) hashCode = hashCode * 59 + this.IfExistTraffic.GetHashCode();
                hashCode = hashCode * 59 + this.Pop.GetHashCode();
                return hashCode;
            }
        }
    }
}
