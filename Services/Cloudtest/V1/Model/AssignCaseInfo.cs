using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 用例关联信息
    /// </summary>
    public class AssignCaseInfo 
    {

        /// <summary>
        /// 用例URI
        /// </summary>
        [JsonProperty("case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseUri { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignCaseInfo {\n");
            sb.Append("  caseUri: ").Append(CaseUri).Append("\n");
            sb.Append("  isAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssignCaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssignCaseInfo input)
        {
            if (input == null) return false;
            if (this.CaseUri != input.CaseUri || (this.CaseUri != null && !this.CaseUri.Equals(input.CaseUri))) return false;
            if (this.IsAvailable != input.IsAvailable || (this.IsAvailable != null && !this.IsAvailable.Equals(input.IsAvailable))) return false;

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
                if (this.CaseUri != null) hashCode = hashCode * 59 + this.CaseUri.GetHashCode();
                if (this.IsAvailable != null) hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                return hashCode;
            }
        }
    }
}
