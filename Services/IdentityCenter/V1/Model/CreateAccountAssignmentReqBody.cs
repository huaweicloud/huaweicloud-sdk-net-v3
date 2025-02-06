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
    /// CreateAccountAssignment请求体
    /// </summary>
    public class CreateAccountAssignmentReqBody 
    {
        /// <summary>
        /// 创建绑定的实体类型
        /// </summary>
        /// <value>创建绑定的实体类型</value>
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

            public static bool operator !=(PrincipalTypeEnum a, PrincipalTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 创建绑定的实体类型.
        /// </summary>
        /// <value>创建绑定的实体类型.</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum ACCOUNT for value: ACCOUNT
            /// </summary>
            public static readonly TargetTypeEnum ACCOUNT = new TargetTypeEnum("ACCOUNT");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "ACCOUNT", ACCOUNT },
            };

            private string _value;

            public TargetTypeEnum()
            {

            }

            public TargetTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
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

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 权限集唯一标识
        /// </summary>
        [JsonProperty("permission_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionSetId { get; set; }

        /// <summary>
        /// IAM身份中心中的一个实体身份唯一标识，例如用户或用户组
        /// </summary>
        [JsonProperty("principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 创建绑定的实体类型
        /// </summary>
        [JsonProperty("principal_type", NullValueHandling = NullValueHandling.Ignore)]
        public PrincipalTypeEnum PrincipalType { get; set; }
        /// <summary>
        /// 待绑定的目标实体标识.
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 创建绑定的实体类型.
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountAssignmentReqBody {\n");
            sb.Append("  permissionSetId: ").Append(PermissionSetId).Append("\n");
            sb.Append("  principalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  principalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccountAssignmentReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccountAssignmentReqBody input)
        {
            if (input == null) return false;
            if (this.PermissionSetId != input.PermissionSetId || (this.PermissionSetId != null && !this.PermissionSetId.Equals(input.PermissionSetId))) return false;
            if (this.PrincipalId != input.PrincipalId || (this.PrincipalId != null && !this.PrincipalId.Equals(input.PrincipalId))) return false;
            if (this.PrincipalType != input.PrincipalType) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetType != input.TargetType) return false;

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
                if (this.PermissionSetId != null) hashCode = hashCode * 59 + this.PermissionSetId.GetHashCode();
                if (this.PrincipalId != null) hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
