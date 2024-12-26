using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FirewallStatusVO 
    {

        /// <summary>
        /// 可防护eip数量
        /// </summary>
        [JsonProperty("available_eip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableEipCount { get; set; }

        /// <summary>
        /// 是否超出eip数量限制
        /// </summary>
        [JsonProperty("beyond_max_count", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BeyondMaxCount { get; set; }

        /// <summary>
        /// 已防护eip数量
        /// </summary>
        [JsonProperty("eip_protected_self", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtectedSelf { get; set; }

        /// <summary>
        /// eip总数
        /// </summary>
        [JsonProperty("eip_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipTotal { get; set; }

        /// <summary>
        /// 未防护eip数量
        /// </summary>
        [JsonProperty("eip_un_protected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipUnProtected { get; set; }

        /// <summary>
        /// 防护对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 是否开启新增eip自动防护，1；是，0：否
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallStatusVO {\n");
            sb.Append("  availableEipCount: ").Append(AvailableEipCount).Append("\n");
            sb.Append("  beyondMaxCount: ").Append(BeyondMaxCount).Append("\n");
            sb.Append("  eipProtectedSelf: ").Append(EipProtectedSelf).Append("\n");
            sb.Append("  eipTotal: ").Append(EipTotal).Append("\n");
            sb.Append("  eipUnProtected: ").Append(EipUnProtected).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallStatusVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallStatusVO input)
        {
            if (input == null) return false;
            if (this.AvailableEipCount != input.AvailableEipCount || (this.AvailableEipCount != null && !this.AvailableEipCount.Equals(input.AvailableEipCount))) return false;
            if (this.BeyondMaxCount != input.BeyondMaxCount || (this.BeyondMaxCount != null && !this.BeyondMaxCount.Equals(input.BeyondMaxCount))) return false;
            if (this.EipProtectedSelf != input.EipProtectedSelf || (this.EipProtectedSelf != null && !this.EipProtectedSelf.Equals(input.EipProtectedSelf))) return false;
            if (this.EipTotal != input.EipTotal || (this.EipTotal != null && !this.EipTotal.Equals(input.EipTotal))) return false;
            if (this.EipUnProtected != input.EipUnProtected || (this.EipUnProtected != null && !this.EipUnProtected.Equals(input.EipUnProtected))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.AvailableEipCount != null) hashCode = hashCode * 59 + this.AvailableEipCount.GetHashCode();
                if (this.BeyondMaxCount != null) hashCode = hashCode * 59 + this.BeyondMaxCount.GetHashCode();
                if (this.EipProtectedSelf != null) hashCode = hashCode * 59 + this.EipProtectedSelf.GetHashCode();
                if (this.EipTotal != null) hashCode = hashCode * 59 + this.EipTotal.GetHashCode();
                if (this.EipUnProtected != null) hashCode = hashCode * 59 + this.EipUnProtected.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
