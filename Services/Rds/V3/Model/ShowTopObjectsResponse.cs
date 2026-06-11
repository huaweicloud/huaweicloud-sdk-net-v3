using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTopObjectsResponse : SdkResponse
    {

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("cur_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurTime { get; set; }

        /// <summary>
        /// 明细
        /// </summary>
        [JsonProperty("top_object_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopObject> TopObjectList { get; set; }

        /// <summary>
        /// 总览
        /// </summary>
        [JsonProperty("top_object_overview_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopObjectOverview> TopObjectOverviewList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopObjectsResponse {\n");
            sb.Append("  curTime: ").Append(CurTime).Append("\n");
            sb.Append("  topObjectList: ").Append(TopObjectList).Append("\n");
            sb.Append("  topObjectOverviewList: ").Append(TopObjectOverviewList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopObjectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopObjectsResponse input)
        {
            if (input == null) return false;
            if (this.CurTime != input.CurTime || (this.CurTime != null && !this.CurTime.Equals(input.CurTime))) return false;
            if (this.TopObjectList != input.TopObjectList || (this.TopObjectList != null && input.TopObjectList != null && !this.TopObjectList.SequenceEqual(input.TopObjectList))) return false;
            if (this.TopObjectOverviewList != input.TopObjectOverviewList || (this.TopObjectOverviewList != null && input.TopObjectOverviewList != null && !this.TopObjectOverviewList.SequenceEqual(input.TopObjectOverviewList))) return false;

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
                if (this.CurTime != null) hashCode = hashCode * 59 + this.CurTime.GetHashCode();
                if (this.TopObjectList != null) hashCode = hashCode * 59 + this.TopObjectList.GetHashCode();
                if (this.TopObjectOverviewList != null) hashCode = hashCode * 59 + this.TopObjectOverviewList.GetHashCode();
                return hashCode;
            }
        }
    }
}
