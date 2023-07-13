using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AreaDetail 
    {

        /// <summary>
        /// 各个计费大区名称，例如CN
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 时间戳及相应时间的指标数值
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TimeValue> Summary { get; set; }

        /// <summary>
        /// 各个大区下的具体省份、区域、国家的时间戳及相应时间的指标数值
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<AreaTimeValue> Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AreaDetail {\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AreaDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AreaDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Summary == input.Summary ||
                    this.Summary != null &&
                    input.Summary != null &&
                    this.Summary.SequenceEqual(input.Summary)
                ) && 
                (
                    this.Detail == input.Detail ||
                    this.Detail != null &&
                    input.Detail != null &&
                    this.Detail.SequenceEqual(input.Detail)
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
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
