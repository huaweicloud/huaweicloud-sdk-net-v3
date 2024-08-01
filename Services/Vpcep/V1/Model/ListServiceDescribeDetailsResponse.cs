using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServiceDescribeDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 终端节点服务的ID，唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 终端节点服务的名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 终端节点服务类型。仅支持将用户私有服务创建为interface类型的终端节点服务。  - gateway：由运维人员配置。用户无需创建，可直接使用。  - interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过创建终端节点创建访问Gateway和Interface类型终端节点服务的终端节点。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 终端节点服务的创建时间。 采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 连接该终端节点服务的终端节点是否计费。  - true：计费  - false：不计费
        /// </summary>
        [JsonProperty("is_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCharge { get; set; }

        /// <summary>
        /// 终端节点对应Pool的Public Border Group信息
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 是否允许自定义终端节点策略。  - false：不支持设置终端节点策略  - true：支持设置终端节点策略 默认为false
        /// </summary>
        [JsonProperty("enable_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceDescribeDetailsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  isCharge: ").Append(IsCharge).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  enablePolicy: ").Append(EnablePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceDescribeDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceDescribeDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.IsCharge == input.IsCharge ||
                    (this.IsCharge != null &&
                    this.IsCharge.Equals(input.IsCharge))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.EnablePolicy == input.EnablePolicy ||
                    (this.EnablePolicy != null &&
                    this.EnablePolicy.Equals(input.EnablePolicy))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.IsCharge != null)
                    hashCode = hashCode * 59 + this.IsCharge.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.EnablePolicy != null)
                    hashCode = hashCode * 59 + this.EnablePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
