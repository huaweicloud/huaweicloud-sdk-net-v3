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
    /// 需求通过情况
    /// </summary>
    public class IssuePassDetailsVo 
    {

        /// <summary>
        /// 统计测试中的需求
        /// </summary>
        [JsonProperty("testing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Testing { get; set; }

        /// <summary>
        /// 统计已完成的需求
        /// </summary>
        [JsonProperty("finished", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finished { get; set; }

        /// <summary>
        /// 统计未完成的需求
        /// </summary>
        [JsonProperty("not_tested", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotTested { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuePassDetailsVo {\n");
            sb.Append("  testing: ").Append(Testing).Append("\n");
            sb.Append("  finished: ").Append(Finished).Append("\n");
            sb.Append("  notTested: ").Append(NotTested).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssuePassDetailsVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssuePassDetailsVo input)
        {
            if (input == null) return false;
            if (this.Testing != input.Testing || (this.Testing != null && !this.Testing.Equals(input.Testing))) return false;
            if (this.Finished != input.Finished || (this.Finished != null && !this.Finished.Equals(input.Finished))) return false;
            if (this.NotTested != input.NotTested || (this.NotTested != null && !this.NotTested.Equals(input.NotTested))) return false;

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
                if (this.Testing != null) hashCode = hashCode * 59 + this.Testing.GetHashCode();
                if (this.Finished != null) hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.NotTested != null) hashCode = hashCode * 59 + this.NotTested.GetHashCode();
                return hashCode;
            }
        }
    }
}
