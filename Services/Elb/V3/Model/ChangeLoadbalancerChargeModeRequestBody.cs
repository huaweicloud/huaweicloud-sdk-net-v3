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
    /// This is a auto create Body Object
    /// </summary>
    public class ChangeLoadbalancerChargeModeRequestBody 
    {
        /// <summary>
        /// 计费模式。  取值： - prepaid：包周期计费。
        /// </summary>
        /// <value>计费模式。  取值： - prepaid：包周期计费。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum PREPAID for value: prepaid
            /// </summary>
            public static readonly ChargeModeEnum PREPAID = new ChargeModeEnum("prepaid");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "prepaid", PREPAID },
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
        /// 需要修改计费类型的负载均衡器ID列表。
        /// </summary>
        [JsonProperty("loadbalancer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerIds { get; set; }

        /// <summary>
        /// 计费模式。  取值： - prepaid：包周期计费。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidChangeChargeModeOption PrepaidOptions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeLoadbalancerChargeModeRequestBody {\n");
            sb.Append("  loadbalancerIds: ").Append(LoadbalancerIds).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeLoadbalancerChargeModeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeLoadbalancerChargeModeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoadbalancerIds == input.LoadbalancerIds ||
                    this.LoadbalancerIds != null &&
                    input.LoadbalancerIds != null &&
                    this.LoadbalancerIds.SequenceEqual(input.LoadbalancerIds)
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.PrepaidOptions == input.PrepaidOptions ||
                    (this.PrepaidOptions != null &&
                    this.PrepaidOptions.Equals(input.PrepaidOptions))
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
                if (this.LoadbalancerIds != null)
                    hashCode = hashCode * 59 + this.LoadbalancerIds.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.PrepaidOptions != null)
                    hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
