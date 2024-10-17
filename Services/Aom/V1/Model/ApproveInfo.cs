using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 审批信息
    /// </summary>
    public class ApproveInfo 
    {

        /// <summary>
        /// 审批人主题选择。
        /// </summary>
        [JsonProperty("topic_selected", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicSelected { get; set; }

        /// <summary>
        /// 是否审核,默认是不审核，true，false。
        /// </summary>
        [JsonProperty("need_approve", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedApprove { get; set; }

        /// <summary>
        /// 审批主题urn集合。
        /// </summary>
        [JsonProperty("smn_urn_list", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnUrnList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApproveInfo {\n");
            sb.Append("  topicSelected: ").Append(TopicSelected).Append("\n");
            sb.Append("  needApprove: ").Append(NeedApprove).Append("\n");
            sb.Append("  smnUrnList: ").Append(SmnUrnList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApproveInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApproveInfo input)
        {
            if (input == null) return false;
            if (this.TopicSelected != input.TopicSelected || (this.TopicSelected != null && !this.TopicSelected.Equals(input.TopicSelected))) return false;
            if (this.NeedApprove != input.NeedApprove || (this.NeedApprove != null && !this.NeedApprove.Equals(input.NeedApprove))) return false;
            if (this.SmnUrnList != input.SmnUrnList || (this.SmnUrnList != null && !this.SmnUrnList.Equals(input.SmnUrnList))) return false;

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
                if (this.TopicSelected != null) hashCode = hashCode * 59 + this.TopicSelected.GetHashCode();
                if (this.NeedApprove != null) hashCode = hashCode * 59 + this.NeedApprove.GetHashCode();
                if (this.SmnUrnList != null) hashCode = hashCode * 59 + this.SmnUrnList.GetHashCode();
                return hashCode;
            }
        }
    }
}
