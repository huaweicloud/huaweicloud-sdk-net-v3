using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListControlsForOrganizationalUnitResponse : SdkResponse
    {

        /// <summary>
        /// 治理策略概要。
        /// </summary>
        [JsonProperty("control_summaries", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetControl> ControlSummaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListControlsForOrganizationalUnitResponse {\n");
            sb.Append("  controlSummaries: ").Append(ControlSummaries).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListControlsForOrganizationalUnitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListControlsForOrganizationalUnitResponse input)
        {
            if (input == null) return false;
            if (this.ControlSummaries != input.ControlSummaries || (this.ControlSummaries != null && input.ControlSummaries != null && !this.ControlSummaries.SequenceEqual(input.ControlSummaries))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ControlSummaries != null) hashCode = hashCode * 59 + this.ControlSummaries.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
