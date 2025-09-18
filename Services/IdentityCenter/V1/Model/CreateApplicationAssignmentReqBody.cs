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
    /// CreateApplicationAssignment的请求体
    /// </summary>
    public class CreateApplicationAssignmentReqBody 
    {
        /// <summary>
        /// 主体类型
        /// </summary>
        /// <value>主体类型</value>
        [JsonConverter(typeof(EnumClassConverter<PrincipalTypeEnum>))]
        public class PrincipalTypeEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly PrincipalTypeEnum USER = new PrincipalTypeEnum("USER");

            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            public static readonly PrincipalTypeEnum GROUP = new PrincipalTypeEnum("GROUP");

            private static readonly Dictionary<string, PrincipalTypeEnum> StaticFields =
            new Dictionary<string, PrincipalTypeEnum>()
            {
                { "USER", USER },
                { "GROUP", GROUP },
            };

            private string _value;

            public PrincipalTypeEnum()
            {

            }

            public PrincipalTypeEnum(string value)
            {
                _value = value;
            }

            public static PrincipalTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PrincipalTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PrincipalTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PrincipalTypeEnum a, PrincipalTypeEnum b)
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

            public static bool operator !=(PrincipalTypeEnum a, PrincipalTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主体Id
        /// </summary>
        [JsonProperty("principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [JsonProperty("principal_type", NullValueHandling = NullValueHandling.Ignore)]
        public PrincipalTypeEnum PrincipalType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationAssignmentReqBody {\n");
            sb.Append("  principalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  principalType: ").Append(PrincipalType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationAssignmentReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationAssignmentReqBody input)
        {
            if (input == null) return false;
            if (this.PrincipalId != input.PrincipalId || (this.PrincipalId != null && !this.PrincipalId.Equals(input.PrincipalId))) return false;
            if (this.PrincipalType != input.PrincipalType) return false;

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
                if (this.PrincipalId != null) hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                return hashCode;
            }
        }
    }
}
