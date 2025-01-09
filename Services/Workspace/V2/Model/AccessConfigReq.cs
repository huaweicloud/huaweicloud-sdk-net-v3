using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 接入配置
    /// </summary>
    public class AccessConfigReq 
    {
        /// <summary>
        /// 接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。
        /// </summary>
        /// <value>接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。</value>
        [JsonConverter(typeof(EnumClassConverter<AccessModeEnum>))]
        public class AccessModeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: INTERNET
            /// </summary>
            public static readonly AccessModeEnum INTERNET = new AccessModeEnum("INTERNET");

            /// <summary>
            /// Enum DEDICATED for value: DEDICATED
            /// </summary>
            public static readonly AccessModeEnum DEDICATED = new AccessModeEnum("DEDICATED");

            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            public static readonly AccessModeEnum BOTH = new AccessModeEnum("BOTH");

            private static readonly Dictionary<string, AccessModeEnum> StaticFields =
            new Dictionary<string, AccessModeEnum>()
            {
                { "INTERNET", INTERNET },
                { "DEDICATED", DEDICATED },
                { "BOTH", BOTH },
            };

            private string _value;

            public AccessModeEnum()
            {

            }

            public AccessModeEnum(string value)
            {
                _value = value;
            }

            public static AccessModeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessModeEnum a, AccessModeEnum b)
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

            public static bool operator !=(AccessModeEnum a, AccessModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AccessModeEnum AccessMode { get; set; }
        /// <summary>
        /// 专线接入网段列表，多个网段信息用分号隔开，列表长度不超过5。
        /// </summary>
        [JsonProperty("dedicated_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedCidrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigReq {\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  dedicatedCidrs: ").Append(DedicatedCidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigReq input)
        {
            if (input == null) return false;
            if (this.AccessMode != input.AccessMode) return false;
            if (this.DedicatedCidrs != input.DedicatedCidrs || (this.DedicatedCidrs != null && !this.DedicatedCidrs.Equals(input.DedicatedCidrs))) return false;

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
                hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.DedicatedCidrs != null) hashCode = hashCode * 59 + this.DedicatedCidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
