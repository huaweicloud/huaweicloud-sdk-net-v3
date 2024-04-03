using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Flavor 
    {
        /// <summary>
        /// 防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版，购买时，当防火墙“charge_mode”为“postPaid”时，仅支持专业版。“charge_mode”为“prePaid”时，支持标准版、专业版。
        /// </summary>
        /// <value>防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版，购买时，当防火墙“charge_mode”为“postPaid”时，仅支持专业版。“charge_mode”为“prePaid”时，支持标准版、专业版。</value>
        [JsonConverter(typeof(EnumClassConverter<VersionEnum>))]
        public class VersionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly VersionEnum NUMBER_0 = new VersionEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly VersionEnum NUMBER_1 = new VersionEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly VersionEnum NUMBER_2 = new VersionEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly VersionEnum NUMBER_3 = new VersionEnum(3);

            private static readonly Dictionary<int?, VersionEnum> StaticFields =
            new Dictionary<int?, VersionEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public VersionEnum()
            {

            }

            public VersionEnum(int? value)
            {
                _value = value;
            }

            public static VersionEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as VersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VersionEnum a, VersionEnum b)
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

            public static bool operator !=(VersionEnum a, VersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版，购买时，当防火墙“charge_mode”为“postPaid”时，仅支持专业版。“charge_mode”为“prePaid”时，支持标准版、专业版。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public VersionEnum Version { get; set; }
        /// <summary>
        /// eip数量
        /// </summary>
        [JsonProperty("eip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipCount { get; set; }

        /// <summary>
        /// vpc数量
        /// </summary>
        [JsonProperty("vpc_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcCount { get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 日志存储
        /// </summary>
        [JsonProperty("log_storage", NullValueHandling = NullValueHandling.Ignore)]
        public int? LogStorage { get; set; }

        /// <summary>
        /// 目前的会话数
        /// </summary>
        [JsonProperty("session_concurrent", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionConcurrent { get; set; }

        /// <summary>
        /// 创建会话数
        /// </summary>
        [JsonProperty("session_create", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionCreate { get; set; }

        /// <summary>
        /// 总计规则数
        /// </summary>
        [JsonProperty("total_rule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRuleCount { get; set; }

        /// <summary>
        /// 已使用规则数
        /// </summary>
        [JsonProperty("used_rule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedRuleCount { get; set; }

        /// <summary>
        /// vpc间带宽
        /// </summary>
        [JsonProperty("vpc_bandwith", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcBandwith { get; set; }

        /// <summary>
        /// 默认防火墙带宽
        /// </summary>
        [JsonProperty("default_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultBandwidth { get; set; }

        /// <summary>
        /// 默认eip数
        /// </summary>
        [JsonProperty("default_eip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultEipCount { get; set; }

        /// <summary>
        /// 默认日志存储
        /// </summary>
        [JsonProperty("default_log_storage", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultLogStorage { get; set; }

        /// <summary>
        /// 默认vpc数
        /// </summary>
        [JsonProperty("default_vpc_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultVpcCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  eipCount: ").Append(EipCount).Append("\n");
            sb.Append("  vpcCount: ").Append(VpcCount).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  logStorage: ").Append(LogStorage).Append("\n");
            sb.Append("  sessionConcurrent: ").Append(SessionConcurrent).Append("\n");
            sb.Append("  sessionCreate: ").Append(SessionCreate).Append("\n");
            sb.Append("  totalRuleCount: ").Append(TotalRuleCount).Append("\n");
            sb.Append("  usedRuleCount: ").Append(UsedRuleCount).Append("\n");
            sb.Append("  vpcBandwith: ").Append(VpcBandwith).Append("\n");
            sb.Append("  defaultBandwidth: ").Append(DefaultBandwidth).Append("\n");
            sb.Append("  defaultEipCount: ").Append(DefaultEipCount).Append("\n");
            sb.Append("  defaultLogStorage: ").Append(DefaultLogStorage).Append("\n");
            sb.Append("  defaultVpcCount: ").Append(DefaultVpcCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.EipCount == input.EipCount ||
                    (this.EipCount != null &&
                    this.EipCount.Equals(input.EipCount))
                ) && 
                (
                    this.VpcCount == input.VpcCount ||
                    (this.VpcCount != null &&
                    this.VpcCount.Equals(input.VpcCount))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.LogStorage == input.LogStorage ||
                    (this.LogStorage != null &&
                    this.LogStorage.Equals(input.LogStorage))
                ) && 
                (
                    this.SessionConcurrent == input.SessionConcurrent ||
                    (this.SessionConcurrent != null &&
                    this.SessionConcurrent.Equals(input.SessionConcurrent))
                ) && 
                (
                    this.SessionCreate == input.SessionCreate ||
                    (this.SessionCreate != null &&
                    this.SessionCreate.Equals(input.SessionCreate))
                ) && 
                (
                    this.TotalRuleCount == input.TotalRuleCount ||
                    (this.TotalRuleCount != null &&
                    this.TotalRuleCount.Equals(input.TotalRuleCount))
                ) && 
                (
                    this.UsedRuleCount == input.UsedRuleCount ||
                    (this.UsedRuleCount != null &&
                    this.UsedRuleCount.Equals(input.UsedRuleCount))
                ) && 
                (
                    this.VpcBandwith == input.VpcBandwith ||
                    (this.VpcBandwith != null &&
                    this.VpcBandwith.Equals(input.VpcBandwith))
                ) && 
                (
                    this.DefaultBandwidth == input.DefaultBandwidth ||
                    (this.DefaultBandwidth != null &&
                    this.DefaultBandwidth.Equals(input.DefaultBandwidth))
                ) && 
                (
                    this.DefaultEipCount == input.DefaultEipCount ||
                    (this.DefaultEipCount != null &&
                    this.DefaultEipCount.Equals(input.DefaultEipCount))
                ) && 
                (
                    this.DefaultLogStorage == input.DefaultLogStorage ||
                    (this.DefaultLogStorage != null &&
                    this.DefaultLogStorage.Equals(input.DefaultLogStorage))
                ) && 
                (
                    this.DefaultVpcCount == input.DefaultVpcCount ||
                    (this.DefaultVpcCount != null &&
                    this.DefaultVpcCount.Equals(input.DefaultVpcCount))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.EipCount != null)
                    hashCode = hashCode * 59 + this.EipCount.GetHashCode();
                if (this.VpcCount != null)
                    hashCode = hashCode * 59 + this.VpcCount.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.LogStorage != null)
                    hashCode = hashCode * 59 + this.LogStorage.GetHashCode();
                if (this.SessionConcurrent != null)
                    hashCode = hashCode * 59 + this.SessionConcurrent.GetHashCode();
                if (this.SessionCreate != null)
                    hashCode = hashCode * 59 + this.SessionCreate.GetHashCode();
                if (this.TotalRuleCount != null)
                    hashCode = hashCode * 59 + this.TotalRuleCount.GetHashCode();
                if (this.UsedRuleCount != null)
                    hashCode = hashCode * 59 + this.UsedRuleCount.GetHashCode();
                if (this.VpcBandwith != null)
                    hashCode = hashCode * 59 + this.VpcBandwith.GetHashCode();
                if (this.DefaultBandwidth != null)
                    hashCode = hashCode * 59 + this.DefaultBandwidth.GetHashCode();
                if (this.DefaultEipCount != null)
                    hashCode = hashCode * 59 + this.DefaultEipCount.GetHashCode();
                if (this.DefaultLogStorage != null)
                    hashCode = hashCode * 59 + this.DefaultLogStorage.GetHashCode();
                if (this.DefaultVpcCount != null)
                    hashCode = hashCode * 59 + this.DefaultVpcCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
