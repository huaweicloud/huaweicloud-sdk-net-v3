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
    public class ListStorageAssignmentRequest 
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
        /// 存储声明的类型，claim_mode为share时，storage_claim_id必填。 * &#x60;USER&#x60; -  用户目录 * &#x60;SHARE&#x60; - 共享目录
        /// </summary>
        [SDKProperty("claim_mode", IsQuery = true)]
        [JsonProperty("claim_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimMode { get; set; }

        /// <summary>
        /// WKS存储目录声明ID。
        /// </summary>
        [SDKProperty("storage_claim_id", IsQuery = true)]
        [JsonProperty("storage_claim_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClaimId { get; set; }

        /// <summary>
        /// 成员。
        /// </summary>
        [SDKProperty("attach", IsQuery = true)]
        [JsonProperty("attach", NullValueHandling = NullValueHandling.Ignore)]
        public string Attach { get; set; }

        /// <summary>
        /// 关联对象类型： * &#x60;USER&#x60; -  用户 * &#x60;USER_GROUP&#x60; - 用户组
        /// </summary>
        [SDKProperty("attach_type", IsQuery = true)]
        [JsonProperty("attach_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageAssignmentRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  storageId: ").Append(StorageId).Append("\n");
            sb.Append("  claimMode: ").Append(ClaimMode).Append("\n");
            sb.Append("  storageClaimId: ").Append(StorageClaimId).Append("\n");
            sb.Append("  attach: ").Append(Attach).Append("\n");
            sb.Append("  attachType: ").Append(AttachType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageAssignmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageAssignmentRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.StorageId != input.StorageId || (this.StorageId != null && !this.StorageId.Equals(input.StorageId))) return false;
            if (this.ClaimMode != input.ClaimMode || (this.ClaimMode != null && !this.ClaimMode.Equals(input.ClaimMode))) return false;
            if (this.StorageClaimId != input.StorageClaimId || (this.StorageClaimId != null && !this.StorageClaimId.Equals(input.StorageClaimId))) return false;
            if (this.Attach != input.Attach || (this.Attach != null && !this.Attach.Equals(input.Attach))) return false;
            if (this.AttachType != input.AttachType || (this.AttachType != null && !this.AttachType.Equals(input.AttachType))) return false;

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
                if (this.StorageClaimId != null) hashCode = hashCode * 59 + this.StorageClaimId.GetHashCode();
                if (this.Attach != null) hashCode = hashCode * 59 + this.Attach.GetHashCode();
                if (this.AttachType != null) hashCode = hashCode * 59 + this.AttachType.GetHashCode();
                return hashCode;
            }
        }
    }
}
