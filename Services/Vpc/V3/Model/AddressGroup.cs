using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddressGroup 
    {

        /// <summary>
        /// 功能说明：地址组唯一标识 取值范围：合法UUID的字符串 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：地址组名称 取值范围：0-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：地址组描述信息 取值范围：0-255个字符 约束：不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：地址组最大条目数，限制地址组可以包含的地址数量 取值范围：0-20 默认值：20
        /// </summary>
        [JsonProperty("max_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// 功能说明：地址组可包含地址集 取值范围：可以是单个ip地址，ip地址范围，ip地址cidr 约束：当前一个地址组ip_set数量限制默认值为20，即配置的ip地址、ip地址范围或ip地址cidr的总数默认限制20 
        /// </summary>
        [JsonProperty("ip_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpSet { get; set; }

        /// <summary>
        /// 功能说明：IP地址组ip版本 取值范围：4, 表示ipv4地址组；6, 表示ipv6地址组
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 功能说明：地址组创建时间 取值范围：UTC时间格式：yyyy-MM-ddTHH:mm:ss；系统自动生成 
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 功能描述：地址组最近一次更新资源的时间 取值范围：UTC时间格式：yyyy-MM-ddTHH:mm:ss；系统自动生成
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 功能说明：资源所属项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：地址组状态 取值范围：       NORMAL：正常       UPDATING：更新中       UPDATE_FAILED：更新失败 默认值：NORMAL 约束：当地址组处于UPDATING（更新中）状态时，不允许再次更新
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 功能说明：地址组状态详情信息
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressGroup {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  maxCapacity: ").Append(MaxCapacity).Append("\n");
            sb.Append("  ipSet: ").Append(IpSet).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddressGroup input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MaxCapacity == input.MaxCapacity ||
                    (this.MaxCapacity != null &&
                    this.MaxCapacity.Equals(input.MaxCapacity))
                ) && 
                (
                    this.IpSet == input.IpSet ||
                    this.IpSet != null &&
                    input.IpSet != null &&
                    this.IpSet.SequenceEqual(input.IpSet)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MaxCapacity != null)
                    hashCode = hashCode * 59 + this.MaxCapacity.GetHashCode();
                if (this.IpSet != null)
                    hashCode = hashCode * 59 + this.IpSet.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
