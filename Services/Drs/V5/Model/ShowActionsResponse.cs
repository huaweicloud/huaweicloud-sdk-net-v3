using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowActionsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_action", NullValueHandling = NullValueHandling.Ignore)]
        public JobActions JobAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowActionsResponse {\n");
            sb.Append("  jobAction: ").Append(JobAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowActionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowActionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobAction == input.JobAction ||
                    (this.JobAction != null &&
                    this.JobAction.Equals(input.JobAction))
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
                if (this.JobAction != null)
                    hashCode = hashCode * 59 + this.JobAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
