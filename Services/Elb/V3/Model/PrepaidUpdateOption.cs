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
    /// **参数解释**：更新负载均衡器实例的预付费计费配置。  **约束限制**：不涉及  [不支持该字段，请勿使用。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,fcs,dt,hcso_dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,srg)
    /// </summary>
    public class PrepaidUpdateOption 
    {
        /// <summary>
        /// **参数解释**：规格变更类型。  **约束限制**：不涉及  **取值范围**： - immediate：即时变更，规格变更立即生效。 - delay：续费变更，当前周期结束后变更为目标规格。  **默认取值**：不涉及
        /// </summary>
        /// <value>**参数解释**：规格变更类型。  **约束限制**：不涉及  **取值范围**： - immediate：即时变更，规格变更立即生效。 - delay：续费变更，当前周期结束后变更为目标规格。  **默认取值**：不涉及</value>
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

            private string _value;

            public ChangeModeEnum()
            {

            }

            public ChangeModeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// **参数解释**：订购周期类型。  **约束限制**：仅在change_mode为delay时生效。  **取值范围**： - month：月 - year：年  **默认取值**：不涉及
        /// </summary>
        /// <value>**参数解释**：订购周期类型。  **约束限制**：仅在change_mode为delay时生效。  **取值范围**： - month：月 - year：年  **默认取值**：不涉及</value>
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
        /// **参数解释**：下单订购后，是否自动从客户的账户中支付。  **约束限制**：自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **取值范围**： - true：自动支付。 - false：不自动支付。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// **参数解释**：规格变更类型。  **约束限制**：不涉及  **取值范围**： - immediate：即时变更，规格变更立即生效。 - delay：续费变更，当前周期结束后变更为目标规格。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("change_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeModeEnum ChangeMode { get; set; }
        /// <summary>
        /// **参数解释**：订购周期数，取值会随运营策略变化。  **约束限制**：仅在change_mode为delay时生效  **取值范围**： - period_type为month时，为[1,9] - period_type为year时，为[1,3]  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// **参数解释**：订购周期类型。  **约束限制**：仅在change_mode为delay时生效。  **取值范围**： - month：月 - year：年  **默认取值**：不涉及
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
            if (input == null) return false;
            if (this.AutoPay != input.AutoPay || (this.AutoPay != null && !this.AutoPay.Equals(input.AutoPay))) return false;
            if (this.ChangeMode != input.ChangeMode) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.PeriodType != input.PeriodType) return false;

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
                if (this.AutoPay != null) hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                hashCode = hashCode * 59 + this.ChangeMode.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
