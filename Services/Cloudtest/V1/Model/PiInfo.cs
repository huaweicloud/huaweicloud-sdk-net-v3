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
    /// pi迭代筛选条件
    /// </summary>
    public class PiInfo 
    {

        /// <summary>
        /// 迭代列表
        /// </summary>
        [JsonProperty("sprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sprints { get; set; }

        /// <summary>
        /// pi的id，层级关系：pi -&gt; 迭代 -&gt; 需求
        /// </summary>
        [JsonProperty("pi_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PiId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PiInfo {\n");
            sb.Append("  sprints: ").Append(Sprints).Append("\n");
            sb.Append("  piId: ").Append(PiId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PiInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PiInfo input)
        {
            if (input == null) return false;
            if (this.Sprints != input.Sprints || (this.Sprints != null && input.Sprints != null && !this.Sprints.SequenceEqual(input.Sprints))) return false;
            if (this.PiId != input.PiId || (this.PiId != null && !this.PiId.Equals(input.PiId))) return false;

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
                if (this.Sprints != null) hashCode = hashCode * 59 + this.Sprints.GetHashCode();
                if (this.PiId != null) hashCode = hashCode * 59 + this.PiId.GetHashCode();
                return hashCode;
            }
        }
    }
}
