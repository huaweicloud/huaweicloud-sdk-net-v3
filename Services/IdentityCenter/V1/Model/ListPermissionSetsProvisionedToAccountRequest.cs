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
    public class ListPermissionSetsProvisionedToAccountRequest 
    {
        /// <summary>
        /// 权限集授权状态
        /// </summary>
        /// <value>权限集授权状态</value>
        [JsonConverter(typeof(EnumClassConverter<ProvisioningStatusEnum>))]
        public class ProvisioningStatusEnum
        {
            /// <summary>
            /// Enum LATEST_PERMISSION_SET_PROVISIONED for value: LATEST_PERMISSION_SET_PROVISIONED
            /// </summary>
            public static readonly ProvisioningStatusEnum LATEST_PERMISSION_SET_PROVISIONED = new ProvisioningStatusEnum("LATEST_PERMISSION_SET_PROVISIONED");

            /// <summary>
            /// Enum LATEST_PERMISSION_SET_NOT_PROVISIONED for value: LATEST_PERMISSION_SET_NOT_PROVISIONED
            /// </summary>
            public static readonly ProvisioningStatusEnum LATEST_PERMISSION_SET_NOT_PROVISIONED = new ProvisioningStatusEnum("LATEST_PERMISSION_SET_NOT_PROVISIONED");

            private static readonly Dictionary<string, ProvisioningStatusEnum> StaticFields =
            new Dictionary<string, ProvisioningStatusEnum>()
            {
                { "LATEST_PERMISSION_SET_PROVISIONED", LATEST_PERMISSION_SET_PROVISIONED },
                { "LATEST_PERMISSION_SET_NOT_PROVISIONED", LATEST_PERMISSION_SET_NOT_PROVISIONED },
            };

            private string _value;

            public ProvisioningStatusEnum()
            {

            }

            public ProvisioningStatusEnum(string value)
            {
                _value = value;
            }

            public static ProvisioningStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ProvisioningStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProvisioningStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
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

            public static bool operator !=(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
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
        /// IAM身份中心实例的全局唯一标识符（ID）。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 每个请求返回的最大结果数
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
        /// 账号的唯一身份标识
        /// </summary>
        [SDKProperty("account_id", IsQuery = true)]
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 权限集授权状态
        /// </summary>
        [SDKProperty("provisioning_status", IsQuery = true)]
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProvisioningStatusEnum ProvisioningStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPermissionSetsProvisionedToAccountRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPermissionSetsProvisionedToAccountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPermissionSetsProvisionedToAccountRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.ProvisioningStatus != input.ProvisioningStatus) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
