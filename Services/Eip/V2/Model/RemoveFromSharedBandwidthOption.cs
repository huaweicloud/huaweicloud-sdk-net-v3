using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 带宽对象
    /// </summary>
    public class RemoveFromSharedBandwidthOption 
    {
        /// <summary>
        /// 弹性公网IP从共享带宽移除后，会为此弹性公网IP创建独占带宽进行计费。  此参数表示弹性公网IP从共享带宽移除后，使用的独占带宽的计费类型。（bandwidth/traffic）
        /// </summary>
        /// <value>弹性公网IP从共享带宽移除后，会为此弹性公网IP创建独占带宽进行计费。  此参数表示弹性公网IP从共享带宽移除后，使用的独占带宽的计费类型。（bandwidth/traffic）</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum BANDWIDTH for value: bandwidth
            /// </summary>
            public static readonly ChargeModeEnum BANDWIDTH = new ChargeModeEnum("bandwidth");

            /// <summary>
            /// Enum TRAFFIC for value: traffic
            /// </summary>
            public static readonly ChargeModeEnum TRAFFIC = new ChargeModeEnum("traffic");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "bandwidth", BANDWIDTH },
                { "traffic", TRAFFIC },
            };

            private string Value;

            public ChargeModeEnum(string value)
            {
                Value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性公网IP从共享带宽移除后，会为此弹性公网IP创建独占带宽进行计费。  此参数表示弹性公网IP从共享带宽移除后，使用的独占带宽的计费类型。（bandwidth/traffic）
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 功能说明：要从共享带宽中移除的弹性公网IP或者IPv6端口信息  约束：WHOLE类型的带宽支持多个弹性公网IP或者IPv6端口，跟租户的配额相关，默认一个共享带宽的配额为20
        /// </summary>
        [JsonProperty("publicip_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemovePublicipInfo> PublicipInfo { get; set; }

        /// <summary>
        /// 弹性公网IP从共享带宽移除后，会为此弹性公网IP创建独占带宽进行计费。  此参数表示弹性公网IP从共享带宽移除后，使用的独占带宽的带宽大小。（M）取值范围：默认为1~2000Mbit/s. 可能因为局点配置不同而不同。也跟带宽的计费模式（bandwidth/traffic）相关。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveFromSharedBandwidthOption {\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  publicipInfo: ").Append(PublicipInfo).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoveFromSharedBandwidthOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoveFromSharedBandwidthOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.PublicipInfo == input.PublicipInfo ||
                    this.PublicipInfo != null &&
                    input.PublicipInfo != null &&
                    this.PublicipInfo.SequenceEqual(input.PublicipInfo)
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.PublicipInfo != null)
                    hashCode = hashCode * 59 + this.PublicipInfo.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
