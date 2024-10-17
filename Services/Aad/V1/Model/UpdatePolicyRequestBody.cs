using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 更新策略的请求体
    /// </summary>
    public class UpdatePolicyRequestBody 
    {
        /// <summary>
        /// udp协议封禁。block：封禁，unblock：不封禁
        /// </summary>
        /// <value>udp协议封禁。block：封禁，unblock：不封禁</value>
        [JsonConverter(typeof(EnumClassConverter<UdpEnum>))]
        public class UdpEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly UdpEnum BLOCK = new UdpEnum("block");

            /// <summary>
            /// Enum UNBLOCK for value: unblock
            /// </summary>
            public static readonly UdpEnum UNBLOCK = new UdpEnum("unblock");

            private static readonly Dictionary<string, UdpEnum> StaticFields =
            new Dictionary<string, UdpEnum>()
            {
                { "block", BLOCK },
                { "unblock", UNBLOCK },
            };

            private string _value;

            public UdpEnum()
            {

            }

            public UdpEnum(string value)
            {
                _value = value;
            }

            public static UdpEnum FromValue(string value)
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

                if (this.Equals(obj as UdpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UdpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UdpEnum a, UdpEnum b)
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

            public static bool operator !=(UdpEnum a, UdpEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// udp协议封禁。block：封禁，unblock：不封禁
        /// </summary>
        [JsonProperty("udp", NullValueHandling = NullValueHandling.Ignore)]
        public UdpEnum Udp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePolicyRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  udp: ").Append(Udp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Udp != input.Udp) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Udp.GetHashCode();
                return hashCode;
            }
        }
    }
}
