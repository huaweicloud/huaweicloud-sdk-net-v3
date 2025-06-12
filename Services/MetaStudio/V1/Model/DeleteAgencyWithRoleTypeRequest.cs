using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteAgencyWithRoleTypeRequest 
    {
        /// <summary>
        /// 委托授权类型 * CBS:对话机器人服务(CBS)访客 * SIS:语音交互服务(SIS)调用
        /// </summary>
        /// <value>委托授权类型 * CBS:对话机器人服务(CBS)访客 * SIS:语音交互服务(SIS)调用</value>
        [JsonConverter(typeof(EnumClassConverter<RoleTypeEnum>))]
        public class RoleTypeEnum
        {
            /// <summary>
            /// Enum CBS for value: CBS
            /// </summary>
            public static readonly RoleTypeEnum CBS = new RoleTypeEnum("CBS");

            /// <summary>
            /// Enum SIS for value: SIS
            /// </summary>
            public static readonly RoleTypeEnum SIS = new RoleTypeEnum("SIS");

            private static readonly Dictionary<string, RoleTypeEnum> StaticFields =
            new Dictionary<string, RoleTypeEnum>()
            {
                { "CBS", CBS },
                { "SIS", SIS },
            };

            private string _value;

            public RoleTypeEnum()
            {

            }

            public RoleTypeEnum(string value)
            {
                _value = value;
            }

            public static RoleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RoleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleTypeEnum a, RoleTypeEnum b)
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

            public static bool operator !=(RoleTypeEnum a, RoleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 委托授权类型 * CBS:对话机器人服务(CBS)访客 * SIS:语音交互服务(SIS)调用
        /// </summary>
        [SDKProperty("role_type", IsPath = true)]
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoleTypeEnum RoleType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAgencyWithRoleTypeRequest {\n");
            sb.Append("  roleType: ").Append(RoleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAgencyWithRoleTypeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAgencyWithRoleTypeRequest input)
        {
            if (input == null) return false;
            if (this.RoleType != input.RoleType) return false;

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
                hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
