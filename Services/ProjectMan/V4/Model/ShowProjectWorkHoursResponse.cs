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
    public class ShowProjectWorkHoursResponse : SdkResponse
    {

        /// <summary>
        /// 工时列表
        /// </summary>
        [JsonProperty("work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowProjectWorkHoursResponseBodyWorkHours> WorkHours { get; set; }

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
            sb.Append("class ShowProjectWorkHoursResponse {\n");
            sb.Append("  workHours: ").Append(WorkHours).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectWorkHoursResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectWorkHoursResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkHours == input.WorkHours ||
                    this.WorkHours != null &&
                    input.WorkHours != null &&
                    this.WorkHours.SequenceEqual(input.WorkHours)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WorkHours != null)
                    hashCode = hashCode * 59 + this.WorkHours.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
