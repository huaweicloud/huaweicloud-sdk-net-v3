using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BssParam 
    {
        /// <summary>
        /// 当选择包年包月时，该字段为必选，表示是否自动续订资源。 取值范围： - false：不自动续订； - true：自动续订； 默认值为：false 约束： 如果设置为自动续订，到期后，会自动续订一个月（自动续订时间后续可能会变化），详情可联系客服咨询。 
        /// </summary>
        /// <value>当选择包年包月时，该字段为必选，表示是否自动续订资源。 取值范围： - false：不自动续订； - true：自动续订； 默认值为：false 约束： 如果设置为自动续订，到期后，会自动续订一个月（自动续订时间后续可能会变化），详情可联系客服咨询。 </value>
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

            public static readonly Dictionary<string, IsAutoRenewEnum> StaticFields =
            new Dictionary<string, IsAutoRenewEnum>()
            {
                {"true", TRUE},
                {"false", FALSE},
            };

            private string Value;

            public IsAutoRenewEnum(string Value)
            {
                this.Value = Value;
            }

            public static IsAutoRenewEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 功能说明：付费方式（预付费、按需付费；预付费，即包周期付费）。 取值范围： - prePaid -预付费，即包年包月； - postPaid -后付费，即按需付费； 默认值是postPaid。 后付费的场景下，bss_param参数的其他字段都会被忽略。 
        /// </summary>
        /// <value>功能说明：付费方式（预付费、按需付费；预付费，即包周期付费）。 取值范围： - prePaid -预付费，即包年包月； - postPaid -后付费，即按需付费； 默认值是postPaid。 后付费的场景下，bss_param参数的其他字段都会被忽略。 </value>
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

            public static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                {"prePaid", PREPAID},
                {"postPaid", POSTPAID},
            };

            private string Value;

            public ChargingModeEnum(string Value)
            {
                this.Value = Value;
            }

            public static ChargingModeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 
        /// </summary>
        /// <value>功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 </value>
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

            public static readonly Dictionary<string, IsAutoPayEnum> StaticFields =
            new Dictionary<string, IsAutoPayEnum>()
            {
                {"true", TRUE},
                {"false", FALSE},
            };

            private string Value;

            public IsAutoPayEnum(string Value)
            {
                this.Value = Value;
            }

            public static IsAutoPayEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 当选择包年包月时，该字段为必选，表示订购资源的周期类型。  取值范围如下： - month：表示包月 - year：表示包年 
        /// </summary>
        /// <value>当选择包年包月时，该字段为必选，表示订购资源的周期类型。  取值范围如下： - month：表示包月 - year：表示包年 </value>
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

            public static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                {"month", MONTH},
                {"year", YEAR},
            };

            private string Value;

            public PeriodTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static PeriodTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 当选择包年包月时，该字段为必选，表示是否自动续订资源。 取值范围： - false：不自动续订； - true：自动续订； 默认值为：false 约束： 如果设置为自动续订，到期后，会自动续订一个月（自动续订时间后续可能会变化），详情可联系客服咨询。 
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoRenewEnum IsAutoRenew { get; set; }
        /// <summary>
        /// 功能说明：付费方式（预付费、按需付费；预付费，即包周期付费）。 取值范围： - prePaid -预付费，即包年包月； - postPaid -后付费，即按需付费； 默认值是postPaid。 后付费的场景下，bss_param参数的其他字段都会被忽略。 
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoPayEnum IsAutoPay { get; set; }
        /// <summary>
        /// 当选择包年包月时，该字段为必选，表示订购资源的周期类型。  取值范围如下： - month：表示包月 - year：表示包年 
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 功能说明：订购周期数 取值范围：(后续会随运营策略变化) - period_type为month时，为[1,9]， - period_type为year时，为[1,3] 约束：同period_type约束。 
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BssParam {\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BssParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BssParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
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
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
