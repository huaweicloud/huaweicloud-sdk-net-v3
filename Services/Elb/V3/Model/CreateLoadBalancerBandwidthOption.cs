using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 参数解释：带宽信息
    /// </summary>
    public class CreateLoadBalancerBandwidthOption 
    {
        /// <summary>
        /// 参数解释：计费模式。bandwidth 按带宽计费；traffic 按流量计费。  约束限制：当id字段为null时，charge_mode是必须的。  [当前仅支持traffic按流量计费。](tag:hws_eu,g42,hk_g42,dt,dt_test,hcso_dt)  取值范围：  - bandwidth：按带宽计费。  - traffic： 按流量计费。
        /// </summary>
        /// <value>参数解释：计费模式。bandwidth 按带宽计费；traffic 按流量计费。  约束限制：当id字段为null时，charge_mode是必须的。  [当前仅支持traffic按流量计费。](tag:hws_eu,g42,hk_g42,dt,dt_test,hcso_dt)  取值范围：  - bandwidth：按带宽计费。  - traffic： 按流量计费。</value>
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

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 参数解释：带宽类型。  约束限制： - 当id字段为null时，share_type是必须的。当id不为null时，该字段被忽略。 - 该字段为WHOLE时,必须指定带宽ID。 - IPv6的EIP不支持WHOLE类型带宽。  取值范围： - PER：独享带宽。 - WHOLE：共享带宽。
        /// </summary>
        /// <value>参数解释：带宽类型。  约束限制： - 当id字段为null时，share_type是必须的。当id不为null时，该字段被忽略。 - 该字段为WHOLE时,必须指定带宽ID。 - IPv6的EIP不支持WHOLE类型带宽。  取值范围： - PER：独享带宽。 - WHOLE：共享带宽。</value>
        [JsonConverter(typeof(EnumClassConverter<ShareTypeEnum>))]
        public class ShareTypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly ShareTypeEnum PER = new ShareTypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly ShareTypeEnum WHOLE = new ShareTypeEnum("WHOLE");

            private static readonly Dictionary<string, ShareTypeEnum> StaticFields =
            new Dictionary<string, ShareTypeEnum>()
            {
                { "PER", PER },
                { "WHOLE", WHOLE },
            };

            private string _value;

            public ShareTypeEnum()
            {

            }

            public ShareTypeEnum(string value)
            {
                _value = value;
            }

            public static ShareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ShareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ShareTypeEnum a, ShareTypeEnum b)
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

            public static bool operator !=(ShareTypeEnum a, ShareTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数解释：带宽名称。  约束限制： - 如果share_type是PER，该字段是必选。 - 如果bandwidth对象的id有值，该字段被忽略。  取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：带宽大小。  约束限制：当id字段为null时，size是必须的。 注意，调整带宽时的最小单位会根据带宽范围不同存在差异。 - 小于等于300Mbit/s: 默认最小单位为1Mbit/s。 - 300Mbit/s~1000Mbit/s: 默认最小单位为50Mbit/s。 - 大于1000Mbit/s: 默认最小单位为500Mbit/s。  取值范围：默认1Mbit/s~2000Mbit/s(具体范围以各区域配置为准,请参见控制台对应页面显示)。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 参数解释：计费模式。bandwidth 按带宽计费；traffic 按流量计费。  约束限制：当id字段为null时，charge_mode是必须的。  [当前仅支持traffic按流量计费。](tag:hws_eu,g42,hk_g42,dt,dt_test,hcso_dt)  取值范围：  - bandwidth：按带宽计费。  - traffic： 按流量计费。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 参数解释：带宽类型。  约束限制： - 当id字段为null时，share_type是必须的。当id不为null时，该字段被忽略。 - 该字段为WHOLE时,必须指定带宽ID。 - IPv6的EIP不支持WHOLE类型带宽。  取值范围： - PER：独享带宽。 - WHOLE：共享带宽。
        /// </summary>
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public ShareTypeEnum ShareType { get; set; }
        /// <summary>
        /// 参数解释：资源计费信息。  约束限制： [如果billing_info不为空，说明是包周期计费的带宽，否则为按需计费的带宽。](tag:hws)  [不支持该字段，请勿使用。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,srg,fcs,fcs_vm,dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,ct)
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 参数解释：共享带宽ID。使用已存在的共享带宽。  约束限制：必须是已存在共享带宽ID。在预付费的情况下，不填该字段。该字段取空字符串时，会被忽略。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerBandwidthOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerBandwidthOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerBandwidthOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.ShareType != input.ShareType) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && !this.BillingInfo.Equals(input.BillingInfo))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
