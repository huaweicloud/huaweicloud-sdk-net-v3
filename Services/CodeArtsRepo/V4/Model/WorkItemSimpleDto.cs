using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// **参数解释：** 关联工作项基本信息。
    /// </summary>
    public class WorkItemSimpleDto 
    {

        /// <summary>
        /// **参数解释：** 工作项编号。
        /// </summary>
        [JsonProperty("related_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedId { get; set; }

        /// <summary>
        /// **参数解释：** 工作项地址。
        /// </summary>
        [JsonProperty("related_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemSimpleDto {\n");
            sb.Append("  relatedId: ").Append(RelatedId).Append("\n");
            sb.Append("  relatedUrl: ").Append(RelatedUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemSimpleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemSimpleDto input)
        {
            if (input == null) return false;
            if (this.RelatedId != input.RelatedId || (this.RelatedId != null && !this.RelatedId.Equals(input.RelatedId))) return false;
            if (this.RelatedUrl != input.RelatedUrl || (this.RelatedUrl != null && !this.RelatedUrl.Equals(input.RelatedUrl))) return false;

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
                if (this.RelatedId != null) hashCode = hashCode * 59 + this.RelatedId.GetHashCode();
                if (this.RelatedUrl != null) hashCode = hashCode * 59 + this.RelatedUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
