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
    /// 共享目录分配关联对象。
    /// </summary>
    public class AssignShareFolderReq 
    {

        /// <summary>
        /// WKS存储目录声明ID。
        /// </summary>
        [JsonProperty("storage_claim_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClaimId { get; set; }

        /// <summary>
        /// 增加的成员列表。
        /// </summary>
        [JsonProperty("add_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Assignment> AddItems { get; set; }

        /// <summary>
        /// 移除的成员列表。
        /// </summary>
        [JsonProperty("del_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> DelItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignShareFolderReq {\n");
            sb.Append("  storageClaimId: ").Append(StorageClaimId).Append("\n");
            sb.Append("  addItems: ").Append(AddItems).Append("\n");
            sb.Append("  delItems: ").Append(DelItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssignShareFolderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssignShareFolderReq input)
        {
            if (input == null) return false;
            if (this.StorageClaimId != input.StorageClaimId || (this.StorageClaimId != null && !this.StorageClaimId.Equals(input.StorageClaimId))) return false;
            if (this.AddItems != input.AddItems || (this.AddItems != null && input.AddItems != null && !this.AddItems.SequenceEqual(input.AddItems))) return false;
            if (this.DelItems != input.DelItems || (this.DelItems != null && input.DelItems != null && !this.DelItems.SequenceEqual(input.DelItems))) return false;

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
                if (this.StorageClaimId != null) hashCode = hashCode * 59 + this.StorageClaimId.GetHashCode();
                if (this.AddItems != null) hashCode = hashCode * 59 + this.AddItems.GetHashCode();
                if (this.DelItems != null) hashCode = hashCode * 59 + this.DelItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
