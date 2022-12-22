using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrePaidServerExtendParam 
    {
        /// <summary>
        /// 计费模式。  功能说明：付费方式  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费； - 默认值是postPaid  &gt; 说明： &gt;  &gt; 当chargingMode为prePaid（即创建包年包月付费的云服务器），且使用SSH秘钥方式登录云服务器时，metadata 中的 op_svc_userid 字段为必选字段。
        /// </summary>
        /// <value>计费模式。  功能说明：付费方式  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费； - 默认值是postPaid  &gt; 说明： &gt;  &gt; 当chargingMode为prePaid（即创建包年包月付费的云服务器），且使用SSH秘钥方式登录云服务器时，metadata 中的 op_svc_userid 字段为必选字段。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PREPAID for value: prePaid
            /// </summary>
            public static readonly ChargingModeEnum PREPAID = new ChargingModeEnum("prePaid");

            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly ChargingModeEnum POSTPAID = new ChargingModeEnum("postPaid");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "prePaid", PREPAID },
                { "postPaid", POSTPAID },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 订购周期类型。  取值范围：  - month-月 - year-年  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效且为必选值。
        /// </summary>
        /// <value>订购周期类型。  取值范围：  - month-月 - year-年  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效且为必选值。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum MONTH for value: month
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("month");

            /// <summary>
            /// Enum YEAR for value: year
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("year");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "month", MONTH },
                { "year", YEAR },
            };

            private string _value;

            public PeriodTypeEnum()
            {

            }

            public PeriodTypeEnum(string value)
            {
                _value = value;
            }

            public static PeriodTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PeriodTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
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

            public static bool operator !=(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否自动续订。  - “true”：自动续订 - “false”：不自动续订  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为不自动续订。
        /// </summary>
        /// <value>是否自动续订。  - “true”：自动续订 - “false”：不自动续订  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为不自动续订。</value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoRenewEnum>))]
        public class IsAutoRenewEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoRenewEnum TRUE = new IsAutoRenewEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoRenewEnum FALSE = new IsAutoRenewEnum("false");

            private static readonly Dictionary<string, IsAutoRenewEnum> StaticFields =
            new Dictionary<string, IsAutoRenewEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsAutoRenewEnum()
            {

            }

            public IsAutoRenewEnum(string value)
            {
                _value = value;
            }

            public static IsAutoRenewEnum FromValue(string value)
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

                if (this.Equals(obj as IsAutoRenewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsAutoRenewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsAutoRenewEnum a, IsAutoRenewEnum b)
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

            public static bool operator !=(IsAutoRenewEnum a, IsAutoRenewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 下单订购后，是否自动从客户的账户中支付，而不需要客户手动去进行支付。  - “true”：是（自动支付） - “false”：否（需要客户手动支付）  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为客户手动支付。
        /// </summary>
        /// <value>下单订购后，是否自动从客户的账户中支付，而不需要客户手动去进行支付。  - “true”：是（自动支付） - “false”：否（需要客户手动支付）  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为客户手动支付。</value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoPayEnum>))]
        public class IsAutoPayEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoPayEnum TRUE = new IsAutoPayEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoPayEnum FALSE = new IsAutoPayEnum("false");

            private static readonly Dictionary<string, IsAutoPayEnum> StaticFields =
            new Dictionary<string, IsAutoPayEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsAutoPayEnum()
            {

            }

            public IsAutoPayEnum(string value)
            {
                _value = value;
            }

            public static IsAutoPayEnum FromValue(string value)
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

                if (this.Equals(obj as IsAutoPayEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsAutoPayEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsAutoPayEnum a, IsAutoPayEnum b)
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

            public static bool operator !=(IsAutoPayEnum a, IsAutoPayEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 竞价实例中断策略，当前支持immediate。  - 当interruption_policy&#x3D;immediate时表示释放策略为立即释放。 
        /// </summary>
        /// <value>竞价实例中断策略，当前支持immediate。  - 当interruption_policy&#x3D;immediate时表示释放策略为立即释放。 </value>
        [JsonConverter(typeof(EnumClassConverter<InterruptionPolicyEnum>))]
        public class InterruptionPolicyEnum
        {
            /// <summary>
            /// Enum IMMEDIATE for value: immediate
            /// </summary>
            public static readonly InterruptionPolicyEnum IMMEDIATE = new InterruptionPolicyEnum("immediate");

            private static readonly Dictionary<string, InterruptionPolicyEnum> StaticFields =
            new Dictionary<string, InterruptionPolicyEnum>()
            {
                { "immediate", IMMEDIATE },
            };

            private string _value;

            public InterruptionPolicyEnum()
            {

            }

            public InterruptionPolicyEnum(string value)
            {
                _value = value;
            }

            public static InterruptionPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as InterruptionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InterruptionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
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

            public static bool operator !=(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 计费模式。  功能说明：付费方式  取值范围：  - prePaid-预付费，即包年包月； - postPaid-后付费，即按需付费； - 默认值是postPaid  &gt; 说明： &gt;  &gt; 当chargingMode为prePaid（即创建包年包月付费的云服务器），且使用SSH秘钥方式登录云服务器时，metadata 中的 op_svc_userid 字段为必选字段。
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 云服务器所在区域ID。  请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)获取。
        /// </summary>
        [JsonProperty("regionID", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionID { get; set; }

        /// <summary>
        /// 订购周期类型。  取值范围：  - month-月 - year-年  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效且为必选值。
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 订购周期数。  取值范围：  - periodType&#x3D;month（周期类型为月）时，取值为[1，9]； - periodType&#x3D;year（周期类型为年）时，取值为[1，3]；  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效且为必选值。 &gt;  &gt; periodNum为正整数。
        /// </summary>
        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订。  - “true”：自动续订 - “false”：不自动续订  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为不自动续订。
        /// </summary>
        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoRenewEnum IsAutoRenew { get; set; }
        /// <summary>
        /// 下单订购后，是否自动从客户的账户中支付，而不需要客户手动去进行支付。  - “true”：是（自动支付） - “false”：否（需要客户手动支付）  &gt; 说明： &gt;  &gt; chargingMode为prePaid时生效，不传该字段时默认为客户手动支付。
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoPayEnum IsAutoPay { get; set; }
        /// <summary>
        /// 企业项目ID。  &gt; 说明： &gt;  &gt; 关于企业项目ID的获取及企业项目特性的详细信息，请参见《[企业管理服务用户指南](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)》。 &gt;  &gt; 该字段不传（或传为字符串“0”），则将资源绑定给默认企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否配置弹性云服务器自动恢复的功能。  - “true”：配置该功能 - “false”：不配置该功能  &gt; 说明： &gt;  &gt; 此参数为boolean类型，若传入非boolean类型字符，程序将按照【“false”：不配置该功能】方式处理。 &gt;  &gt; 当marketType为spot时，不支持该功能。
        /// </summary>
        [JsonProperty("support_auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAutoRecovery { get; set; }

        /// <summary>
        /// 创建竞价实例时，需指定该参数的值为“spot”。  &gt; 说明： &gt;  &gt; 当chargingMode&#x3D;postPaid且marketType&#x3D;spot时，此参数生效。
        /// </summary>
        [JsonProperty("marketType", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketType { get; set; }

        /// <summary>
        /// 用户愿意为竞价实例每小时支付的最高价格。  &gt; 说明： &gt;  &gt; 仅chargingMode&#x3D;postPaid且marketType&#x3D;spot时，该参数设置后生效。 &gt;  &gt; 当chargingMode&#x3D;postPaid且marketType&#x3D;spot时，如果不传递spotPrice或者传递一个空字符串，默认使用按需购买的价格作为竞价。
        /// </summary>
        [JsonProperty("spotPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotPrice { get; set; }

        /// <summary>
        /// 是否支持先创建卷，再创建虚拟机。  “true”：配置该功能 “false”：不配置该功能
        /// </summary>
        [JsonProperty("diskPrior", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskPrior { get; set; }

        /// <summary>
        /// 购买的竞价实例时长。  - 仅interruption_policy&#x3D;immediate 时该字段有效 。 - spot_duration_hours大于0。最大值由预测系统给出可以从flavor的extra_specs的cond:spot_block:operation:longest_duration_hours字段中查询。
        /// </summary>
        [JsonProperty("spot_duration_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpotDurationHours { get; set; }

        /// <summary>
        /// 竞价实例中断策略，当前支持immediate。  - 当interruption_policy&#x3D;immediate时表示释放策略为立即释放。 
        /// </summary>
        [JsonProperty("interruption_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InterruptionPolicyEnum InterruptionPolicy { get; set; }
        /// <summary>
        /// 表示购买的“竞价实例时长”的个数。  - 仅spot_duration_hours&gt;0 时该字段有效。 - spot_duration_hours小于6时，spot_duration_count值必须为1。 - spot_duration_hours等于6时，spot_duration_count大于等于1。  spot_duration_count的最大值由预测系统给出可以从flavor的extra_specs的cond:spot_block:operation:longest_duration_count字段中查询。  
        /// </summary>
        [JsonProperty("spot_duration_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpotDurationCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerExtendParam {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  regionID: ").Append(RegionID).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  supportAutoRecovery: ").Append(SupportAutoRecovery).Append("\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("  spotPrice: ").Append(SpotPrice).Append("\n");
            sb.Append("  diskPrior: ").Append(DiskPrior).Append("\n");
            sb.Append("  spotDurationHours: ").Append(SpotDurationHours).Append("\n");
            sb.Append("  interruptionPolicy: ").Append(InterruptionPolicy).Append("\n");
            sb.Append("  spotDurationCount: ").Append(SpotDurationCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidServerExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.RegionID == input.RegionID ||
                    (this.RegionID != null &&
                    this.RegionID.Equals(input.RegionID))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.SupportAutoRecovery == input.SupportAutoRecovery ||
                    (this.SupportAutoRecovery != null &&
                    this.SupportAutoRecovery.Equals(input.SupportAutoRecovery))
                ) && 
                (
                    this.MarketType == input.MarketType ||
                    (this.MarketType != null &&
                    this.MarketType.Equals(input.MarketType))
                ) && 
                (
                    this.SpotPrice == input.SpotPrice ||
                    (this.SpotPrice != null &&
                    this.SpotPrice.Equals(input.SpotPrice))
                ) && 
                (
                    this.DiskPrior == input.DiskPrior ||
                    (this.DiskPrior != null &&
                    this.DiskPrior.Equals(input.DiskPrior))
                ) && 
                (
                    this.SpotDurationHours == input.SpotDurationHours ||
                    (this.SpotDurationHours != null &&
                    this.SpotDurationHours.Equals(input.SpotDurationHours))
                ) && 
                (
                    this.InterruptionPolicy == input.InterruptionPolicy ||
                    (this.InterruptionPolicy != null &&
                    this.InterruptionPolicy.Equals(input.InterruptionPolicy))
                ) && 
                (
                    this.SpotDurationCount == input.SpotDurationCount ||
                    (this.SpotDurationCount != null &&
                    this.SpotDurationCount.Equals(input.SpotDurationCount))
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
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.RegionID != null)
                    hashCode = hashCode * 59 + this.RegionID.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SupportAutoRecovery != null)
                    hashCode = hashCode * 59 + this.SupportAutoRecovery.GetHashCode();
                if (this.MarketType != null)
                    hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.SpotPrice != null)
                    hashCode = hashCode * 59 + this.SpotPrice.GetHashCode();
                if (this.DiskPrior != null)
                    hashCode = hashCode * 59 + this.DiskPrior.GetHashCode();
                if (this.SpotDurationHours != null)
                    hashCode = hashCode * 59 + this.SpotDurationHours.GetHashCode();
                if (this.InterruptionPolicy != null)
                    hashCode = hashCode * 59 + this.InterruptionPolicy.GetHashCode();
                if (this.SpotDurationCount != null)
                    hashCode = hashCode * 59 + this.SpotDurationCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
