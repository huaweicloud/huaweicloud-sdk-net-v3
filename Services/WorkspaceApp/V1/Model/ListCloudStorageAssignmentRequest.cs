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
    /// Request Object
    /// </summary>
    public class ListCloudStorageAssignmentRequest 
    {

        /// <summary>
        /// 查询的偏移量。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 单次查询的大小[1-100]。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// WKS存储ID。
        /// </summary>
        [SDKProperty("storage_id", IsQuery = true)]
        [JsonProperty("storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageId { get; set; }

        /// <summary>
        /// 存储声明的类型,目前只支持USER,后面可以拓展。 * &#x60;USER&#x60; -  个人文件夹 * &#x60;SHARE&#x60; -  共享文件夹
        /// </summary>
        [SDKProperty("claim_mode", IsQuery = true)]
        [JsonProperty("claim_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimMode { get; set; }

        /// <summary>
        /// 被分配的个体或组的名称，当传attach_names时，本字段不生效。
        /// </summary>
        [SDKProperty("attach", IsQuery = true)]
        [JsonProperty("attach", NullValueHandling = NullValueHandling.Ignore)]
        public string Attach { get; set; }

        /// <summary>
        /// 被分配的个体或组的名称。
        /// </summary>
        [SDKProperty("attach_names", IsQuery = true)]
        [JsonProperty("attach_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachNames { get; set; }

        /// <summary>
        /// 是否查询容量过滤： - true : 是。 - false: 否。
        /// </summary>
        [SDKProperty("capacity_filter", IsQuery = true)]
        [JsonProperty("capacity_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string CapacityFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloudStorageAssignmentRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  storageId: ").Append(StorageId).Append("\n");
            sb.Append("  claimMode: ").Append(ClaimMode).Append("\n");
            sb.Append("  attach: ").Append(Attach).Append("\n");
            sb.Append("  attachNames: ").Append(AttachNames).Append("\n");
            sb.Append("  capacityFilter: ").Append(CapacityFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloudStorageAssignmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloudStorageAssignmentRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.StorageId != input.StorageId || (this.StorageId != null && !this.StorageId.Equals(input.StorageId))) return false;
            if (this.ClaimMode != input.ClaimMode || (this.ClaimMode != null && !this.ClaimMode.Equals(input.ClaimMode))) return false;
            if (this.Attach != input.Attach || (this.Attach != null && !this.Attach.Equals(input.Attach))) return false;
            if (this.AttachNames != input.AttachNames || (this.AttachNames != null && input.AttachNames != null && !this.AttachNames.SequenceEqual(input.AttachNames))) return false;
            if (this.CapacityFilter != input.CapacityFilter || (this.CapacityFilter != null && !this.CapacityFilter.Equals(input.CapacityFilter))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.StorageId != null) hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                if (this.ClaimMode != null) hashCode = hashCode * 59 + this.ClaimMode.GetHashCode();
                if (this.Attach != null) hashCode = hashCode * 59 + this.Attach.GetHashCode();
                if (this.AttachNames != null) hashCode = hashCode * 59 + this.AttachNames.GetHashCode();
                if (this.CapacityFilter != null) hashCode = hashCode * 59 + this.CapacityFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
