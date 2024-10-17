using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHealthObjectCompareJobOverviewResponse : SdkResponse
    {

        /// <summary>
        /// 健康对比对象级对比结果。
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectsHealthCompareOverviewInfo> CompareResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHealthObjectCompareJobOverviewResponse {\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHealthObjectCompareJobOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHealthObjectCompareJobOverviewResponse input)
        {
            if (input == null) return false;
            if (this.CompareResult != input.CompareResult || (this.CompareResult != null && input.CompareResult != null && !this.CompareResult.SequenceEqual(input.CompareResult))) return false;

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
                if (this.CompareResult != null) hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
