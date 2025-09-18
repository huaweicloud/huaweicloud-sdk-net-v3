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
    /// 创建文件夹返回信息。
    /// </summary>
    public class CloudStorageAssignmentCreateInfo 
    {

        /// <summary>
        /// 存储分配的唯一标识符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 域ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 文件夹名称。
        /// </summary>
        [JsonProperty("folder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderName { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("attach", NullValueHandling = NullValueHandling.Ignore)]
        public string Attach { get; set; }

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("attach_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attach_type", NullValueHandling = NullValueHandling.Ignore)]
        public AttachType? AttachType { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否创建成功。
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudStorageAssignmentCreateInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  folderName: ").Append(FolderName).Append("\n");
            sb.Append("  attach: ").Append(Attach).Append("\n");
            sb.Append("  attachId: ").Append(AttachId).Append("\n");
            sb.Append("  attachType: ").Append(AttachType).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudStorageAssignmentCreateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudStorageAssignmentCreateInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.FolderName != input.FolderName || (this.FolderName != null && !this.FolderName.Equals(input.FolderName))) return false;
            if (this.Attach != input.Attach || (this.Attach != null && !this.Attach.Equals(input.Attach))) return false;
            if (this.AttachId != input.AttachId || (this.AttachId != null && !this.AttachId.Equals(input.AttachId))) return false;
            if (this.AttachType != input.AttachType || (this.AttachType != null && !this.AttachType.Equals(input.AttachType))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;

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
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.FolderName != null) hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                if (this.Attach != null) hashCode = hashCode * 59 + this.Attach.GetHashCode();
                if (this.AttachId != null) hashCode = hashCode * 59 + this.AttachId.GetHashCode();
                if (this.AttachType != null) hashCode = hashCode * 59 + this.AttachType.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
