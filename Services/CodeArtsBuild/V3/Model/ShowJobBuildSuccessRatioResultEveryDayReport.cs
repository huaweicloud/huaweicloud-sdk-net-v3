using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowJobBuildSuccessRatioResultEveryDayReport 
    {

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 成功率
        /// </summary>
        [JsonProperty("success_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobBuildSuccessRatioResultEveryDayReport {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  successRatio: ").Append(SuccessRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobBuildSuccessRatioResultEveryDayReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobBuildSuccessRatioResultEveryDayReport input)
        {
            if (input == null) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;
            if (this.SuccessRatio != input.SuccessRatio || (this.SuccessRatio != null && !this.SuccessRatio.Equals(input.SuccessRatio))) return false;

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
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.SuccessRatio != null) hashCode = hashCode * 59 + this.SuccessRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
