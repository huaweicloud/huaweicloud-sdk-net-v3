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
    /// Response Object
    /// </summary>
    public class DescribeApplicationResponse : SdkResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        /// <value>状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly StatusEnum DISABLED = new StatusEnum("DISABLED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用程序URN
        /// </summary>
        [JsonProperty("application_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUrn { get; set; }

        /// <summary>
        /// 应用程序提供商URN
        /// </summary>
        [JsonProperty("application_provider_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationProviderUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignment_config", NullValueHandling = NullValueHandling.Ignore)]
        public AssignmentConfigDto AssignmentConfig { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// 应用程序描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// IAM身份中心实例URN
        /// </summary>
        [JsonProperty("instance_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceUrn { get; set; }

        /// <summary>
        /// 应用程序显示名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("portal_options", NullValueHandling = NullValueHandling.Ignore)]
        public PortalOptionsDto PortalOptions { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 华为云账号
        /// </summary>
        [JsonProperty("application_account", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationAccount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeApplicationResponse {\n");
            sb.Append("  applicationUrn: ").Append(ApplicationUrn).Append("\n");
            sb.Append("  applicationProviderUrn: ").Append(ApplicationProviderUrn).Append("\n");
            sb.Append("  assignmentConfig: ").Append(AssignmentConfig).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceUrn: ").Append(InstanceUrn).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  portalOptions: ").Append(PortalOptions).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  applicationAccount: ").Append(ApplicationAccount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeApplicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeApplicationResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationUrn != input.ApplicationUrn || (this.ApplicationUrn != null && !this.ApplicationUrn.Equals(input.ApplicationUrn))) return false;
            if (this.ApplicationProviderUrn != input.ApplicationProviderUrn || (this.ApplicationProviderUrn != null && !this.ApplicationProviderUrn.Equals(input.ApplicationProviderUrn))) return false;
            if (this.AssignmentConfig != input.AssignmentConfig || (this.AssignmentConfig != null && !this.AssignmentConfig.Equals(input.AssignmentConfig))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceUrn != input.InstanceUrn || (this.InstanceUrn != null && !this.InstanceUrn.Equals(input.InstanceUrn))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PortalOptions != input.PortalOptions || (this.PortalOptions != null && !this.PortalOptions.Equals(input.PortalOptions))) return false;
            if (this.Status != input.Status) return false;
            if (this.ApplicationAccount != input.ApplicationAccount || (this.ApplicationAccount != null && !this.ApplicationAccount.Equals(input.ApplicationAccount))) return false;

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
                if (this.ApplicationUrn != null) hashCode = hashCode * 59 + this.ApplicationUrn.GetHashCode();
                if (this.ApplicationProviderUrn != null) hashCode = hashCode * 59 + this.ApplicationProviderUrn.GetHashCode();
                if (this.AssignmentConfig != null) hashCode = hashCode * 59 + this.AssignmentConfig.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceUrn != null) hashCode = hashCode * 59 + this.InstanceUrn.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PortalOptions != null) hashCode = hashCode * 59 + this.PortalOptions.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ApplicationAccount != null) hashCode = hashCode * 59 + this.ApplicationAccount.GetHashCode();
                return hashCode;
            }
        }
    }
}
