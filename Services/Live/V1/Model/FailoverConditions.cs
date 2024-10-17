using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 主备切换配置
    /// </summary>
    public class FailoverConditions 
    {
        /// <summary>
        /// 以主入流URL为第一优先级（PRIMARY）或主备URL平等切换（EQUAL）  如果为平等切换时使用的是备URL，无需手工切换到主URL
        /// </summary>
        /// <value>以主入流URL为第一优先级（PRIMARY）或主备URL平等切换（EQUAL）  如果为平等切换时使用的是备URL，无需手工切换到主URL</value>
        [JsonConverter(typeof(EnumClassConverter<InputPreferenceEnum>))]
        public class InputPreferenceEnum
        {
            /// <summary>
            /// Enum EQUAL for value: EQUAL
            /// </summary>
            public static readonly InputPreferenceEnum EQUAL = new InputPreferenceEnum("EQUAL");

            /// <summary>
            /// Enum PRIMARY for value: PRIMARY
            /// </summary>
            public static readonly InputPreferenceEnum PRIMARY = new InputPreferenceEnum("PRIMARY");

            private static readonly Dictionary<string, InputPreferenceEnum> StaticFields =
            new Dictionary<string, InputPreferenceEnum>()
            {
                { "EQUAL", EQUAL },
                { "PRIMARY", PRIMARY },
            };

            private string _value;

            public InputPreferenceEnum()
            {

            }

            public InputPreferenceEnum(string value)
            {
                _value = value;
            }

            public static InputPreferenceEnum FromValue(string value)
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

                if (this.Equals(obj as InputPreferenceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InputPreferenceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InputPreferenceEnum a, InputPreferenceEnum b)
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

            public static bool operator !=(InputPreferenceEnum a, InputPreferenceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 入流停止的时长阈值。到达此阈值后，自动触发主备切换  单位：毫秒，取值范围：0 - 3600000
        /// </summary>
        [JsonProperty("input_loss_threshold_msec", NullValueHandling = NullValueHandling.Ignore)]
        public int? InputLossThresholdMsec { get; set; }

        /// <summary>
        /// 以主入流URL为第一优先级（PRIMARY）或主备URL平等切换（EQUAL）  如果为平等切换时使用的是备URL，无需手工切换到主URL
        /// </summary>
        [JsonProperty("input_preference", NullValueHandling = NullValueHandling.Ignore)]
        public InputPreferenceEnum InputPreference { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailoverConditions {\n");
            sb.Append("  inputLossThresholdMsec: ").Append(InputLossThresholdMsec).Append("\n");
            sb.Append("  inputPreference: ").Append(InputPreference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailoverConditions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailoverConditions input)
        {
            if (input == null) return false;
            if (this.InputLossThresholdMsec != input.InputLossThresholdMsec || (this.InputLossThresholdMsec != null && !this.InputLossThresholdMsec.Equals(input.InputLossThresholdMsec))) return false;
            if (this.InputPreference != input.InputPreference) return false;

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
                if (this.InputLossThresholdMsec != null) hashCode = hashCode * 59 + this.InputLossThresholdMsec.GetHashCode();
                hashCode = hashCode * 59 + this.InputPreference.GetHashCode();
                return hashCode;
            }
        }
    }
}
