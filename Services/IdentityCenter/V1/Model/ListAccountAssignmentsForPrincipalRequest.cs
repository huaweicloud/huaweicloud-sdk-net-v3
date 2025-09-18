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
    /// Request Object
    /// </summary>
    public class ListAccountAssignmentsForPrincipalRequest 
    {
        /// <summary>
        /// IAM Identity Center 身份主体类型.
        /// </summary>
        /// <value>IAM Identity Center 身份主体类型.</value>
        [JsonConverter(typeof(EnumClassConverter<PrincipalTypeEnum>))]
        public class PrincipalTypeEnum
        {
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            public static readonly PrincipalTypeEnum GROUP = new PrincipalTypeEnum("GROUP");

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly PrincipalTypeEnum USER = new PrincipalTypeEnum("USER");

            private static readonly Dictionary<string, PrincipalTypeEnum> StaticFields =
            new Dictionary<string, PrincipalTypeEnum>()
            {
                { "GROUP", GROUP },
                { "USER", USER },
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
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// IAM Identity Center实例的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// IAM Identity Center 身份主体的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("principal_id", IsQuery = true)]
        [JsonProperty("principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// IAM Identity Center 身份主体类型.
        /// </summary>
        [SDKProperty("principal_type", IsQuery = true)]
        [JsonProperty("principal_type", NullValueHandling = NullValueHandling.Ignore)]
        public PrincipalTypeEnum PrincipalType { get; set; }
        /// <summary>
        /// 每个请求返回的最大结果数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页标记
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 指定账户的唯一身份标识
        /// </summary>
        [SDKProperty("account_id", IsQuery = true)]
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccountAssignmentsForPrincipalRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  principalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  principalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccountAssignmentsForPrincipalRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccountAssignmentsForPrincipalRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.PrincipalId != input.PrincipalId || (this.PrincipalId != null && !this.PrincipalId.Equals(input.PrincipalId))) return false;
            if (this.PrincipalType != input.PrincipalType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;

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
                if (this.XSecurityToken != null) hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.PrincipalId != null) hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
