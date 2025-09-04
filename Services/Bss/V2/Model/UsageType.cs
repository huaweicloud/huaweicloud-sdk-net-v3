using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UsageType 
    {

        /// <summary>
        /// 使用量类型编码。如：reqNumber。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 使用量类型名称。如：调用次数。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型编码。例如ECS的VM为“hws.resource.type.vm”。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型编码。例如OBS的云服务类型编码为“hws.service.type.obs”。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageType {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsageType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UsageType input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
