using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 私网NAT网关实例的响应体。
    /// </summary>
    public class PrivateNat 
    {
        /// <summary>
        /// 私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型
        /// </summary>
        /// <value>私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型</value>
        [JsonConverter(typeof(EnumClassConverter<SpecEnum>))]
        public class SpecEnum
        {
            /// <summary>
            /// Enum SMALL for value: Small
            /// </summary>
            public static readonly SpecEnum SMALL = new SpecEnum("Small");

            /// <summary>
            /// Enum MEDIUM for value: Medium
            /// </summary>
            public static readonly SpecEnum MEDIUM = new SpecEnum("Medium");

            /// <summary>
            /// Enum LARGE for value: Large
            /// </summary>
            public static readonly SpecEnum LARGE = new SpecEnum("Large");

            /// <summary>
            /// Enum EXTRA_LARGE for value: Extra-large
            /// </summary>
            public static readonly SpecEnum EXTRA_LARGE = new SpecEnum("Extra-large");

            private static readonly Dictionary<string, SpecEnum> StaticFields =
            new Dictionary<string, SpecEnum>()
            {
                { "Small", SMALL },
                { "Medium", MEDIUM },
                { "Large", LARGE },
                { "Extra-large", EXTRA_LARGE },
            };

            private string _value;

            public SpecEnum()
            {

            }

            public SpecEnum(string value)
            {
                _value = value;
            }

            public static SpecEnum FromValue(string value)
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

                if (this.Equals(obj as SpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecEnum a, SpecEnum b)
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

            public static bool operator !=(SpecEnum a, SpecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 私网NAT网关实例的状态。 取值为： \&quot;ACTIVE\&quot;：正常运行 \&quot;FROZEN\&quot;：冻结
        /// </summary>
        /// <value>私网NAT网关实例的状态。 取值为： \&quot;ACTIVE\&quot;：正常运行 \&quot;FROZEN\&quot;：冻结</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum FROZEN for value: FROZEN
            /// </summary>
            public static readonly StatusEnum FROZEN = new StatusEnum("FROZEN");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "FROZEN", FROZEN },
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
        /// 私网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目的ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 私网NAT网关实例的名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 私网NAT网关实例的描述。长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecEnum Spec { get; set; }
        /// <summary>
        /// 私网NAT网关实例的状态。 取值为： \&quot;ACTIVE\&quot;：正常运行 \&quot;FROZEN\&quot;：冻结
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 私网NAT网关实例的创建时间，遵循UTC时间，格式是yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 私网NAT网关实例的更新时间，遵循UTC时间，格式是yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 私网NAT网关实例所属的VPC实例。
        /// </summary>
        [JsonProperty("downlink_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DownlinkVpc> DownlinkVpcs { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateTag> Tags { get; set; }

        /// <summary>
        /// 企业项目ID。 创建私网NAT网关实例时，关联的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateNat {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  downlinkVpcs: ").Append(DownlinkVpcs).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateNat);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateNat input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Spec != input.Spec) return false;
            if (this.Status != input.Status) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.DownlinkVpcs != input.DownlinkVpcs || (this.DownlinkVpcs != null && input.DownlinkVpcs != null && !this.DownlinkVpcs.SequenceEqual(input.DownlinkVpcs))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Spec.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DownlinkVpcs != null) hashCode = hashCode * 59 + this.DownlinkVpcs.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
