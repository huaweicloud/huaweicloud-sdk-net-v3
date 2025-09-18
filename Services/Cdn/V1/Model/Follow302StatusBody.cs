using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Follow302StatusBody 
    {
        /// <summary>
        /// follow302状态，off：关闭，on：开启。
        /// </summary>
        /// <value>follow302状态，off：关闭，on：开启。</value>
        [JsonConverter(typeof(EnumClassConverter<FollowStatusEnum>))]
        public class FollowStatusEnum
        {
            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly FollowStatusEnum OFF = new FollowStatusEnum("off");

            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly FollowStatusEnum ON = new FollowStatusEnum("on");

            private static readonly Dictionary<string, FollowStatusEnum> StaticFields =
            new Dictionary<string, FollowStatusEnum>()
            {
                { "off", OFF },
                { "on", ON },
            };

            private string _value;

            public FollowStatusEnum()
            {

            }

            public FollowStatusEnum(string value)
            {
                _value = value;
            }

            public static FollowStatusEnum FromValue(string value)
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

                if (this.Equals(obj as FollowStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FollowStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FollowStatusEnum a, FollowStatusEnum b)
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

            public static bool operator !=(FollowStatusEnum a, FollowStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 加速域名id。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// follow302状态，off：关闭，on：开启。
        /// </summary>
        [JsonProperty("follow_status", NullValueHandling = NullValueHandling.Ignore)]
        public FollowStatusEnum FollowStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Follow302StatusBody {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  followStatus: ").Append(FollowStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Follow302StatusBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Follow302StatusBody input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.FollowStatus != input.FollowStatus) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                hashCode = hashCode * 59 + this.FollowStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
