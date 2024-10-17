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
    /// Response Object
    /// </summary>
    public class ListProjectWorkHoursTypeResponse : SdkResponse
    {

        /// <summary>
        /// 工时类型列表
        /// </summary>
        [JsonProperty("work_hours_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkHoursType> WorkHoursTypes { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectWorkHoursTypeResponse {\n");
            sb.Append("  workHoursTypes: ").Append(WorkHoursTypes).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectWorkHoursTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectWorkHoursTypeResponse input)
        {
            if (input == null) return false;
            if (this.WorkHoursTypes != input.WorkHoursTypes || (this.WorkHoursTypes != null && input.WorkHoursTypes != null && !this.WorkHoursTypes.SequenceEqual(input.WorkHoursTypes))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.WorkHoursTypes != null) hashCode = hashCode * 59 + this.WorkHoursTypes.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
