using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWorkflowExecutionForPageResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pager", NullValueHandling = NullValueHandling.Ignore)]
        public Pager Pager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hisRecords", NullValueHandling = NullValueHandling.Ignore)]
        public FlowExecutionBriefV2 HisRecords { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkflowExecutionForPageResponse {\n");
            sb.Append("  pager: ").Append(Pager).Append("\n");
            sb.Append("  hisRecords: ").Append(HisRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkflowExecutionForPageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkflowExecutionForPageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pager == input.Pager ||
                    (this.Pager != null &&
                    this.Pager.Equals(input.Pager))
                ) && 
                (
                    this.HisRecords == input.HisRecords ||
                    (this.HisRecords != null &&
                    this.HisRecords.Equals(input.HisRecords))
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
                if (this.Pager != null)
                    hashCode = hashCode * 59 + this.Pager.GetHashCode();
                if (this.HisRecords != null)
                    hashCode = hashCode * 59 + this.HisRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
