using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建网络实例的详细信息。
    /// </summary>
    public class CreateNetworkInstance 
    {
        /// <summary>
        /// 添加到云连接网络实例的类型，有效值： - vpc：虚拟私有云。 - vgw：虚拟网关。
        /// </summary>
        /// <value>添加到云连接网络实例的类型，有效值： - vpc：虚拟私有云。 - vgw：虚拟网关。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly TypeEnum VPC = new TypeEnum("vpc");

            /// <summary>
            /// Enum VGW for value: vgw
            /// </summary>
            public static readonly TypeEnum VGW = new TypeEnum("vgw");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "vpc", VPC },
                { "vgw", VGW },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 网络实例（VPC，VGW）的ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 网络实例（VPC，VGW）所属账号ID。
        /// </summary>
        [JsonProperty("instance_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceDomainId { get; set; }

        /// <summary>
        /// 实例所属项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 云连接实例ID。
        /// </summary>
        [JsonProperty("cloud_connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudConnectionId { get; set; }

        /// <summary>
        /// 添加到云连接网络实例的类型，有效值： - vpc：虚拟私有云。 - vgw：虚拟网关。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 网络实例发布的网段路由列表。
        /// </summary>
        [JsonProperty("cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cidrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNetworkInstance {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceDomainId: ").Append(InstanceDomainId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  cloudConnectionId: ").Append(CloudConnectionId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cidrs: ").Append(Cidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNetworkInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNetworkInstance input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceDomainId != input.InstanceDomainId || (this.InstanceDomainId != null && !this.InstanceDomainId.Equals(input.InstanceDomainId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.CloudConnectionId != input.CloudConnectionId || (this.CloudConnectionId != null && !this.CloudConnectionId.Equals(input.CloudConnectionId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Cidrs != input.Cidrs || (this.Cidrs != null && input.Cidrs != null && !this.Cidrs.SequenceEqual(input.Cidrs))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceDomainId != null) hashCode = hashCode * 59 + this.InstanceDomainId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.CloudConnectionId != null) hashCode = hashCode * 59 + this.CloudConnectionId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Cidrs != null) hashCode = hashCode * 59 + this.Cidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
