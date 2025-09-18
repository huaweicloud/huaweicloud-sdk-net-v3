using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DisasterRecoverStopSimulationRequestBody 
    {
        /// <summary>
        /// 容灾类型。
        /// </summary>
        /// <value>容灾类型。</value>
        [JsonConverter(typeof(EnumClassConverter<DisasterTypeEnum>))]
        public class DisasterTypeEnum
        {
            /// <summary>
            /// Enum STREAM for value: stream
            /// </summary>
            public static readonly DisasterTypeEnum STREAM = new DisasterTypeEnum("stream");

            private static readonly Dictionary<string, DisasterTypeEnum> StaticFields =
            new Dictionary<string, DisasterTypeEnum>()
            {
                { "stream", STREAM },
            };

            private string _value;

            public DisasterTypeEnum()
            {

            }

            public DisasterTypeEnum(string value)
            {
                _value = value;
            }

            public static DisasterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DisasterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisasterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisasterTypeEnum a, DisasterTypeEnum b)
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

            public static bool operator !=(DisasterTypeEnum a, DisasterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容灾类型。
        /// </summary>
        [JsonProperty("disaster_type", NullValueHandling = NullValueHandling.Ignore)]
        public DisasterTypeEnum DisasterType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisasterRecoverStopSimulationRequestBody {\n");
            sb.Append("  disasterType: ").Append(DisasterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisasterRecoverStopSimulationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisasterRecoverStopSimulationRequestBody input)
        {
            if (input == null) return false;
            if (this.DisasterType != input.DisasterType) return false;

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
                hashCode = hashCode * 59 + this.DisasterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
