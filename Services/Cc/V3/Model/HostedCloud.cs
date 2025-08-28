using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 归属云。
    /// </summary>
    public class HostedCloud 
    {
        /// <summary>
        /// - HWCloud (华为云) - Ireland (爱尔兰)
        /// </summary>
        /// <value>- HWCloud (华为云) - Ireland (爱尔兰)</value>
        [JsonConverter(typeof(EnumClassConverter<HostedCloudEnum>))]
        public class HostedCloudEnum
        {
            /// <summary>
            /// Enum HWCLOUD for value: HWCloud
            /// </summary>
            public static readonly HostedCloudEnum HWCLOUD = new HostedCloudEnum("HWCloud");

            /// <summary>
            /// Enum IRELAND for value: Ireland
            /// </summary>
            public static readonly HostedCloudEnum IRELAND = new HostedCloudEnum("Ireland");

            private static readonly Dictionary<string, HostedCloudEnum> StaticFields =
            new Dictionary<string, HostedCloudEnum>()
            {
                { "HWCloud", HWCLOUD },
                { "Ireland", IRELAND },
            };

            private string _value;

            public HostedCloudEnum()
            {

            }

            public HostedCloudEnum(string value)
            {
                _value = value;
            }

            public static HostedCloudEnum FromValue(string value)
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

                if (this.Equals(obj as HostedCloudEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostedCloudEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostedCloudEnum a, HostedCloudEnum b)
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

            public static bool operator !=(HostedCloudEnum a, HostedCloudEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// - HWCloud (华为云) - Ireland (爱尔兰)
        /// </summary>
        [JsonProperty("hosted_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public HostedCloudEnum _HostedCloud { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostedCloud {\n");
            sb.Append("  _hostedCloud: ").Append(_HostedCloud).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostedCloud);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostedCloud input)
        {
            if (input == null) return false;
            if (this._HostedCloud != input._HostedCloud) return false;

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
                hashCode = hashCode * 59 + this._HostedCloud.GetHashCode();
                return hashCode;
            }
        }
    }
}
