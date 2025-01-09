using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 开通桌面上网能力请求体。
    /// </summary>
    public class ApplyDesktopsInternet 
    {
        /// <summary>
        /// eip带宽计费模式 - TRAFFIC：按流量计费。 - BANDWIDTH：按带宽计费。
        /// </summary>
        /// <value>eip带宽计费模式 - TRAFFIC：按流量计费。 - BANDWIDTH：按带宽计费。</value>
        [JsonConverter(typeof(EnumClassConverter<EipChargeModeEnum>))]
        public class EipChargeModeEnum
        {
            /// <summary>
            /// Enum TRAFFIC for value: TRAFFIC
            /// </summary>
            public static readonly EipChargeModeEnum TRAFFIC = new EipChargeModeEnum("TRAFFIC");

            /// <summary>
            /// Enum BANDWIDTH for value: BANDWIDTH
            /// </summary>
            public static readonly EipChargeModeEnum BANDWIDTH = new EipChargeModeEnum("BANDWIDTH");

            private static readonly Dictionary<string, EipChargeModeEnum> StaticFields =
            new Dictionary<string, EipChargeModeEnum>()
            {
                { "TRAFFIC", TRAFFIC },
                { "BANDWIDTH", BANDWIDTH },
            };

            private string _value;

            public EipChargeModeEnum()
            {

            }

            public EipChargeModeEnum(string value)
            {
                _value = value;
            }

            public static EipChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as EipChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EipChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EipChargeModeEnum a, EipChargeModeEnum b)
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

            public static bool operator !=(EipChargeModeEnum a, EipChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 需要开通上网功能的桌面id列表。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 支持的类型请参考EIP服务支持的类型。可通过调用如下链接的接口查询，https://support.huaweicloud.com/api-eip/ShowPublicIpType.html。
        /// </summary>
        [JsonProperty("eip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EipType { get; set; }

        /// <summary>
        /// eip带宽计费模式 - TRAFFIC：按流量计费。 - BANDWIDTH：按带宽计费。
        /// </summary>
        [JsonProperty("eip_charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public EipChargeModeEnum EipChargeMode { get; set; }
        /// <summary>
        /// 带宽大小，单位Mbit/s。默认1Mbit/s~2000Mbit/s（具体范围以各区域配置为准，请参见控制台对应页面显示）。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// 需要购买EIP的数量，当desktop_ids为空时需要填，兼容单独购买EIP场景。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyDesktopsInternet {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  eipType: ").Append(EipType).Append("\n");
            sb.Append("  eipChargeMode: ").Append(EipChargeMode).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyDesktopsInternet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyDesktopsInternet input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.EipType != input.EipType || (this.EipType != null && !this.EipType.Equals(input.EipType))) return false;
            if (this.EipChargeMode != input.EipChargeMode) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.EipType != null) hashCode = hashCode * 59 + this.EipType.GetHashCode();
                hashCode = hashCode * 59 + this.EipChargeMode.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
