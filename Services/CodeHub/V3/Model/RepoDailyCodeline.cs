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
    public class RepoDailyCodeline 
    {

        /// <summary>
        /// 每日增加代码行
        /// </summary>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Additions { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 每日删除代码行
        /// </summary>
        [JsonProperty("deletions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deletions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoDailyCodeline {\n");
            sb.Append("  additions: ").Append(Additions).Append("\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  deletions: ").Append(Deletions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoDailyCodeline);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoDailyCodeline input)
        {
            if (input == null) return false;
            if (this.Additions != input.Additions || (this.Additions != null && !this.Additions.Equals(input.Additions))) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;
            if (this.Deletions != input.Deletions || (this.Deletions != null && !this.Deletions.Equals(input.Deletions))) return false;

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
                if (this.Additions != null) hashCode = hashCode * 59 + this.Additions.GetHashCode();
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Deletions != null) hashCode = hashCode * 59 + this.Deletions.GetHashCode();
                return hashCode;
            }
        }
    }
}
