using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 服务专属凭证元数据。
    /// </summary>
    public class ServiceSpecificCredentialMetadata 
    {
        /// <summary>
        /// 凭证状态。
        /// </summary>
        /// <value>凭证状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("active");

            /// <summary>
            /// Enum INACTIVE for value: inactive
            /// </summary>
            public static readonly StatusEnum INACTIVE = new StatusEnum("inactive");

            /// <summary>
            /// Enum EXPIRED for value: expired
            /// </summary>
            public static readonly StatusEnum EXPIRED = new StatusEnum("expired");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "active", ACTIVE },
                { "inactive", INACTIVE },
                { "expired", EXPIRED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 创建日期和时间，ISO 8601格式。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 关联的服务名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 凭证标识符ID。
        /// </summary>
        [JsonProperty("credential_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CredentialId { get; set; }

        /// <summary>
        /// 凭证状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 与服务专属凭证关联的IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 关联的IAM用户名称。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 过期日期和时间，仅指定credential_age_days时返回。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 凭证的掩码值。
        /// </summary>
        [JsonProperty("credential_mask", NullValueHandling = NullValueHandling.Ignore)]
        public string CredentialMask { get; set; }

        /// <summary>
        /// 凭证描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceSpecificCredentialMetadata {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  credentialId: ").Append(CredentialId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  credentialMask: ").Append(CredentialMask).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceSpecificCredentialMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceSpecificCredentialMetadata input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.CredentialId != input.CredentialId || (this.CredentialId != null && !this.CredentialId.Equals(input.CredentialId))) return false;
            if (this.Status != input.Status) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.CredentialMask != input.CredentialMask || (this.CredentialMask != null && !this.CredentialMask.Equals(input.CredentialMask))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.CredentialId != null) hashCode = hashCode * 59 + this.CredentialId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.CredentialMask != null) hashCode = hashCode * 59 + this.CredentialMask.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
