using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReportInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("report", NullValueHandling = NullValueHandling.Ignore)]
        public ReportBean Report { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportInfo {\n");
            sb.Append("  report: ").Append(Report).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportInfo input)
        {
            if (input == null) return false;
            if (this.Report != input.Report || (this.Report != null && !this.Report.Equals(input.Report))) return false;

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
                if (this.Report != null) hashCode = hashCode * 59 + this.Report.GetHashCode();
                return hashCode;
            }
        }
    }
}
