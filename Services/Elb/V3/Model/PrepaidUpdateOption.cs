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
    /// 负载均衡器的包周期规格变更信息
    /// </summary>
    public class PrepaidUpdateOption 
    {
        /// <summary>
        /// 规格变更类型： immediate：即时变更，规格变更立即生效。（默认） delay：续费变更，当前周期结束后变更为目标规格。
        /// </summary>
        /// <value>规格变更类型： immediate：即时变更，规格变更立即生效。（默认） delay：续费变更，当前周期结束后变更为目标规格。</value>
        [JsonConverter(typeof(EnumClassConverter<ChangeModeEnum>))]
        public class ChangeModeEnum
        {
            /// <summary>
            /// Enum IMMEDIATE for value: immediate
            /// </summary>
            public static readonly ChangeModeEnum IMMEDIATE = new ChangeModeEnum("immediate");

            /// <summary>
            /// Enum DELAY for value: delay
            /// </summary>
            public static readonly ChangeModeEnum DELAY = new ChangeModeEnum("delay");

            private static readonly Dictionary<string, ChangeModeEnum> StaticFields =
            new Dictionary<string, ChangeModeEnum>()
            {
                { "immediate", IMMEDIATE },
                { "delay", DELAY },
            };

            private string Value;

            public ChangeModeEnum(string value)
            {
                Value = value;
            }

            public static ChangeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChangeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChangeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChangeModeEnum a, ChangeModeEnum b)
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

            public static bool operator !=(ChangeModeEnum a, ChangeModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 订购周期类型，当前支持包月和包年： （仅在change_mode为delay时生效） month：月（默认）； year：年；
        /// </summary>
        /// <value>订购周期类型，当前支持包月和包年： （仅在change_mode为delay时生效） month：月（默认）； year：年；</value>
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

            private string Value;

            public PeriodTypeEnum(string value)
            {
                Value = value;
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
        /// 下单订购后，是否自动从客户的账户中支付； true：自动支付； false：不自动支付（默认）。 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。
        /// </summary>
        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// 规格变更类型： immediate：即时变更，规格变更立即生效。（默认） delay：续费变更，当前周期结束后变更为目标规格。
        /// </summary>
        [JsonProperty("change_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeModeEnum ChangeMode { get; set; }
        /// <summary>
        /// 云服务引导URL。 订购订单支付完成后，支付成功的页面嵌入该url的内容。 console传，用户侧api文档不可见该字段。
        /// </summary>
        [JsonProperty("cloud_service_console_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceConsoleUrl { get; set; }

        /// <summary>
        /// 订购周期数（默认1），取值会随运营策略变化。（仅在change_mode为delay时生效） period_type为month时，为[1,9]， period_type为year时，为[1,3]
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 订购周期类型，当前支持包月和包年： （仅在change_mode为delay时生效） month：月（默认）； year：年；
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrepaidUpdateOption {\n");
            sb.Append("  autoPay: ").Append(AutoPay).Append("\n");
            sb.Append("  changeMode: ").Append(ChangeMode).Append("\n");
            sb.Append("  cloudServiceConsoleUrl: ").Append(CloudServiceConsoleUrl).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrepaidUpdateOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrepaidUpdateOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoPay == input.AutoPay ||
                    (this.AutoPay != null &&
                    this.AutoPay.Equals(input.AutoPay))
                ) && 
                (
                    this.ChangeMode == input.ChangeMode ||
                    (this.ChangeMode != null &&
                    this.ChangeMode.Equals(input.ChangeMode))
                ) && 
                (
                    this.CloudServiceConsoleUrl == input.CloudServiceConsoleUrl ||
                    (this.CloudServiceConsoleUrl != null &&
                    this.CloudServiceConsoleUrl.Equals(input.CloudServiceConsoleUrl))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
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
                if (this.AutoPay != null)
                    hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                if (this.ChangeMode != null)
                    hashCode = hashCode * 59 + this.ChangeMode.GetHashCode();
                if (this.CloudServiceConsoleUrl != null)
                    hashCode = hashCode * 59 + this.CloudServiceConsoleUrl.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
