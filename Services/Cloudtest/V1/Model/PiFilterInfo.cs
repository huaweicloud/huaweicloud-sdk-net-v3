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
    /// pi筛选条件
    /// </summary>
    public class PiFilterInfo 
    {

        /// <summary>
        /// pi迭代筛选条件
        /// </summary>
        [JsonProperty("pi_sprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<PiInfo> PiSprints { get; set; }

        /// <summary>
        /// pi下拉框全选标识，全选时为true
        /// </summary>
        [JsonProperty("all_pi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllPi { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PiFilterInfo {\n");
            sb.Append("  piSprints: ").Append(PiSprints).Append("\n");
            sb.Append("  allPi: ").Append(AllPi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PiFilterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PiFilterInfo input)
        {
            if (input == null) return false;
            if (this.PiSprints != input.PiSprints || (this.PiSprints != null && input.PiSprints != null && !this.PiSprints.SequenceEqual(input.PiSprints))) return false;
            if (this.AllPi != input.AllPi || (this.AllPi != null && !this.AllPi.Equals(input.AllPi))) return false;

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
                if (this.PiSprints != null) hashCode = hashCode * 59 + this.PiSprints.GetHashCode();
                if (this.AllPi != null) hashCode = hashCode * 59 + this.AllPi.GetHashCode();
                return hashCode;
            }
        }
    }
}
