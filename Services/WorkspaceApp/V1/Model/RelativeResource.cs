using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 关联资源。
    /// </summary>
    public class RelativeResource 
    {

        /// <summary>
        /// 关联的资源ID。
        /// </summary>
        [JsonProperty("relative_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeResourceId { get; set; }

        /// <summary>
        /// 有资源名称的云资源，都需要返回resourceName，如果为空值，则返回“”。
        /// </summary>
        [JsonProperty("relative_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeResourceName { get; set; }

        /// <summary>
        /// * 关联关系类型，描述relativeResourceId和resourceId间的关联关系：    * 0：挂载(弱关联)，表示relativeResourceId和resourceId两者有关联关系，     * 但是两者可以独立使用、分别进行交易，且分别使用和交易都不影响整套云服务的使用；比如云主机和数据盘。 *     1：绑定(强关联)，表示relativeResourceId和resourceId是强绑定关系，      两者必须一起使用、一起进行交易，缺少其中一个会造成整套云服务不能使用；比如云主机和系统盘。           缺省值为0(挂载)。           subResources中的RelativeResource，此字段是必填；mainResources中的RelativeResource。
        /// </summary>
        [JsonProperty("relative_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelativeType { get; set; }

        /// <summary>
        /// 比如ECS云服务类型为‘hws.service.type.ec2’。
        /// </summary>
        [JsonProperty("relative_cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeCloudServiceType { get; set; }

        /// <summary>
        /// 比如VM的资源类型为‘hws.resource.type.vm’。
        /// </summary>
        [JsonProperty("relative_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeResourceType { get; set; }

        /// <summary>
        /// 扩展信息，Key:Value格式。
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeResource {\n");
            sb.Append("  relativeResourceId: ").Append(RelativeResourceId).Append("\n");
            sb.Append("  relativeResourceName: ").Append(RelativeResourceName).Append("\n");
            sb.Append("  relativeType: ").Append(RelativeType).Append("\n");
            sb.Append("  relativeCloudServiceType: ").Append(RelativeCloudServiceType).Append("\n");
            sb.Append("  relativeResourceType: ").Append(RelativeResourceType).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelativeResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelativeResource input)
        {
            if (input == null) return false;
            if (this.RelativeResourceId != input.RelativeResourceId || (this.RelativeResourceId != null && !this.RelativeResourceId.Equals(input.RelativeResourceId))) return false;
            if (this.RelativeResourceName != input.RelativeResourceName || (this.RelativeResourceName != null && !this.RelativeResourceName.Equals(input.RelativeResourceName))) return false;
            if (this.RelativeType != input.RelativeType || (this.RelativeType != null && !this.RelativeType.Equals(input.RelativeType))) return false;
            if (this.RelativeCloudServiceType != input.RelativeCloudServiceType || (this.RelativeCloudServiceType != null && !this.RelativeCloudServiceType.Equals(input.RelativeCloudServiceType))) return false;
            if (this.RelativeResourceType != input.RelativeResourceType || (this.RelativeResourceType != null && !this.RelativeResourceType.Equals(input.RelativeResourceType))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;

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
                if (this.RelativeResourceId != null) hashCode = hashCode * 59 + this.RelativeResourceId.GetHashCode();
                if (this.RelativeResourceName != null) hashCode = hashCode * 59 + this.RelativeResourceName.GetHashCode();
                if (this.RelativeType != null) hashCode = hashCode * 59 + this.RelativeType.GetHashCode();
                if (this.RelativeCloudServiceType != null) hashCode = hashCode * 59 + this.RelativeCloudServiceType.GetHashCode();
                if (this.RelativeResourceType != null) hashCode = hashCode * 59 + this.RelativeResourceType.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
