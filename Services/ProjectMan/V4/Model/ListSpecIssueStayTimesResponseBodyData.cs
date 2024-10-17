using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListSpecIssueStayTimesResponseBodyData 
    {

        /// <summary>
        /// 工作项id字符串
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 停留时间（单位：秒）
        /// </summary>
        [JsonProperty("stay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StayTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSpecIssueStayTimesResponseBodyData {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  stayTime: ").Append(StayTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSpecIssueStayTimesResponseBodyData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSpecIssueStayTimesResponseBodyData input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StayTime != input.StayTime || (this.StayTime != null && !this.StayTime.Equals(input.StayTime))) return false;

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
                if (this.StayTime != null) hashCode = hashCode * 59 + this.StayTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
