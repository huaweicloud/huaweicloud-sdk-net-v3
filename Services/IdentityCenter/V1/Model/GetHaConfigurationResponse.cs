using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetHaConfigurationResponse : SdkResponse
    {
        /// <summary>
        /// 高可用选项，接受高可用或者拒绝高可用功能。
        /// </summary>
        /// <value>高可用选项，接受高可用或者拒绝高可用功能。</value>
        [JsonConverter(typeof(EnumClassConverter<DisasterRecoveryChoiceEnum>))]
        public class DisasterRecoveryChoiceEnum
        {
            /// <summary>
            /// Enum ACCEPT for value: ACCEPT
            /// </summary>
            public static readonly DisasterRecoveryChoiceEnum ACCEPT = new DisasterRecoveryChoiceEnum("ACCEPT");

            /// <summary>
            /// Enum REJECT for value: REJECT
            /// </summary>
            public static readonly DisasterRecoveryChoiceEnum REJECT = new DisasterRecoveryChoiceEnum("REJECT");

            private static readonly Dictionary<string, DisasterRecoveryChoiceEnum> StaticFields =
            new Dictionary<string, DisasterRecoveryChoiceEnum>()
            {
                { "ACCEPT", ACCEPT },
                { "REJECT", REJECT },
            };

            private string _value;

            public DisasterRecoveryChoiceEnum()
            {

            }

            public DisasterRecoveryChoiceEnum(string value)
            {
                _value = value;
            }

            public static DisasterRecoveryChoiceEnum FromValue(string value)
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

                if (this.Equals(obj as DisasterRecoveryChoiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisasterRecoveryChoiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisasterRecoveryChoiceEnum a, DisasterRecoveryChoiceEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DisasterRecoveryChoiceEnum a, DisasterRecoveryChoiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 高可用选项，接受高可用或者拒绝高可用功能。
        /// </summary>
        [JsonProperty("disaster_recovery_choice", NullValueHandling = NullValueHandling.Ignore)]
        public DisasterRecoveryChoiceEnum DisasterRecoveryChoice { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHaConfigurationResponse {\n");
            sb.Append("  disasterRecoveryChoice: ").Append(DisasterRecoveryChoice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHaConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHaConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.DisasterRecoveryChoice != input.DisasterRecoveryChoice) return false;

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
                hashCode = hashCode * 59 + this.DisasterRecoveryChoice.GetHashCode();
                return hashCode;
            }
        }
    }
}
