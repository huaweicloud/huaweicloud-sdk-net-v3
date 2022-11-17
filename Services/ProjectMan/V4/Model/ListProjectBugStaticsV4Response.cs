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
    public class ListProjectBugStaticsV4Response : SdkResponse
    {

        /// <summary>
        /// bug统计
        /// </summary>
        [JsonProperty("bug_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<BugStatisticResponseV4> BugStatistics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectBugStaticsV4Response {\n");
            sb.Append("  bugStatistics: ").Append(BugStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectBugStaticsV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectBugStaticsV4Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BugStatistics == input.BugStatistics ||
                    this.BugStatistics != null &&
                    input.BugStatistics != null &&
                    this.BugStatistics.SequenceEqual(input.BugStatistics)
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
                if (this.BugStatistics != null)
                    hashCode = hashCode * 59 + this.BugStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
