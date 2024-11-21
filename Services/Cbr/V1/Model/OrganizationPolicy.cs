using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 组织策略
    /// </summary>
    public class OrganizationPolicy 
    {
        /// <summary>
        /// 组织策略类型 - backup: 备份 -  replication: 复制
        /// </summary>
        /// <value>组织策略类型 - backup: 备份 -  replication: 复制</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly OperationTypeEnum BACKUP = new OperationTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly OperationTypeEnum REPLICATION = new OperationTypeEnum("replication");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组织策略ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 组织策略名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 组织策略描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 组织策略类型 - backup: 备份 -  replication: 复制
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 组织策略所属账号ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 策略是否开启
        /// </summary>
        [JsonProperty("policy_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PolicyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_operation_definition", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyoODCreate PolicyOperationDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTriggerReq PolicyTrigger { get; set; }

        /// <summary>
        /// 组织策略状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 组织策略所属账号
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationPolicy {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  policyEnabled: ").Append(PolicyEnabled).Append("\n");
            sb.Append("  policyOperationDefinition: ").Append(PolicyOperationDefinition).Append("\n");
            sb.Append("  policyTrigger: ").Append(PolicyTrigger).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationPolicy input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.OperationType != input.OperationType) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.PolicyEnabled != input.PolicyEnabled || (this.PolicyEnabled != null && !this.PolicyEnabled.Equals(input.PolicyEnabled))) return false;
            if (this.PolicyOperationDefinition != input.PolicyOperationDefinition || (this.PolicyOperationDefinition != null && !this.PolicyOperationDefinition.Equals(input.PolicyOperationDefinition))) return false;
            if (this.PolicyTrigger != input.PolicyTrigger || (this.PolicyTrigger != null && !this.PolicyTrigger.Equals(input.PolicyTrigger))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicyEnabled != null) hashCode = hashCode * 59 + this.PolicyEnabled.GetHashCode();
                if (this.PolicyOperationDefinition != null) hashCode = hashCode * 59 + this.PolicyOperationDefinition.GetHashCode();
                if (this.PolicyTrigger != null) hashCode = hashCode * 59 + this.PolicyTrigger.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
