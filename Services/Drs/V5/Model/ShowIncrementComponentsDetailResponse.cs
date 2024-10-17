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
    public class ShowIncrementComponentsDetailResponse : SdkResponse
    {

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 增量组件详情。
        /// </summary>
        [JsonProperty("increment_components_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IncreComponentDetail> IncrementComponentsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIncrementComponentsDetailResponse {\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  incrementComponentsList: ").Append(IncrementComponentsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIncrementComponentsDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIncrementComponentsDetailResponse input)
        {
            if (input == null) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IncrementComponentsList != input.IncrementComponentsList || (this.IncrementComponentsList != null && input.IncrementComponentsList != null && !this.IncrementComponentsList.SequenceEqual(input.IncrementComponentsList))) return false;

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
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IncrementComponentsList != null) hashCode = hashCode * 59 + this.IncrementComponentsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
