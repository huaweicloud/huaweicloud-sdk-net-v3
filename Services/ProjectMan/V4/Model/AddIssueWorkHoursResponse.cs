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
    public class AddIssueWorkHoursResponse : SdkResponse
    {

        /// <summary>
        /// 已添加的工时列表
        /// </summary>
        [JsonProperty("added_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddIssueWorkHoursResponseBodyAddedWorkHours> AddedWorkHours { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddIssueWorkHoursResponse {\n");
            sb.Append("  addedWorkHours: ").Append(AddedWorkHours).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddIssueWorkHoursResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddIssueWorkHoursResponse input)
        {
            if (input == null) return false;
            if (this.AddedWorkHours != input.AddedWorkHours || (this.AddedWorkHours != null && input.AddedWorkHours != null && !this.AddedWorkHours.SequenceEqual(input.AddedWorkHours))) return false;

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
                if (this.AddedWorkHours != null) hashCode = hashCode * 59 + this.AddedWorkHours.GetHashCode();
                return hashCode;
            }
        }
    }
}
