using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpgradeNodePoolResponse : SdkResponse
    {

        /// <summary>
        /// Job ID returned after the job is delivered. The job ID can be used to query the job execution status.
        /// </summary>
        [JsonProperty("jobid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Jobid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeNodePoolResponse {\n");
            sb.Append("  jobid: ").Append(Jobid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeNodePoolResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeNodePoolResponse input)
        {
            if (input == null) return false;
            if (this.Jobid != input.Jobid || (this.Jobid != null && !this.Jobid.Equals(input.Jobid))) return false;

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
                if (this.Jobid != null) hashCode = hashCode * 59 + this.Jobid.GetHashCode();
                return hashCode;
            }
        }
    }
}
