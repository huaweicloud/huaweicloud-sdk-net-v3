using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BranchList 
    {

        /// <summary>
        /// 指定仓库的分支列表
        /// </summary>
        [JsonProperty("branches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Branch> Branches { get; set; }

        /// <summary>
        /// 指定仓库的分支总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchList {\n");
            sb.Append("  branches: ").Append(Branches).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BranchList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BranchList input)
        {
            if (input == null) return false;
            if (this.Branches != input.Branches || (this.Branches != null && input.Branches != null && !this.Branches.SequenceEqual(input.Branches))) return false;
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
                if (this.Branches != null) hashCode = hashCode * 59 + this.Branches.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
