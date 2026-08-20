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
    /// 修改的工作项属性。
    /// </summary>
    public class BatchBaselineIpdIssuesParamAttribute 
    {

        /// <summary>
        /// 工作项基线标识。
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchBaselineIpdIssuesParamAttribute {\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchBaselineIpdIssuesParamAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchBaselineIpdIssuesParamAttribute input)
        {
            if (input == null) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;

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
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                return hashCode;
            }
        }
    }
}
