using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchResourceShareInvitationReqBody 
    {

        /// <summary>
        /// 资源共享实例的ID列表。
        /// </summary>
        [JsonProperty("resource_share_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// 资源共享邀请的ID列表。
        /// </summary>
        [JsonProperty("resource_share_invitation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceShareInvitationIds { get; set; }

        /// <summary>
        /// 资源共享邀请的当前状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 分页页面的最大值。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页位置标识。从marker指定索引的下一条数据开始查询。查询第一页数据时，不需要传入此参数，查询后续页码数据时，将查询前一页数据响应体中marker值配入此参数。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResourceShareInvitationReqBody {\n");
            sb.Append("  resourceShareIds: ").Append(ResourceShareIds).Append("\n");
            sb.Append("  resourceShareInvitationIds: ").Append(ResourceShareInvitationIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResourceShareInvitationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchResourceShareInvitationReqBody input)
        {
            if (input == null) return false;
            if (this.ResourceShareIds != input.ResourceShareIds || (this.ResourceShareIds != null && input.ResourceShareIds != null && !this.ResourceShareIds.SequenceEqual(input.ResourceShareIds))) return false;
            if (this.ResourceShareInvitationIds != input.ResourceShareInvitationIds || (this.ResourceShareInvitationIds != null && input.ResourceShareInvitationIds != null && !this.ResourceShareInvitationIds.SequenceEqual(input.ResourceShareInvitationIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.ResourceShareIds != null) hashCode = hashCode * 59 + this.ResourceShareIds.GetHashCode();
                if (this.ResourceShareInvitationIds != null) hashCode = hashCode * 59 + this.ResourceShareInvitationIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
