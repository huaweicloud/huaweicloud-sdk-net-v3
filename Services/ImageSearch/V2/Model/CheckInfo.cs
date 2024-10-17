using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 检查结果的相关信息。
    /// </summary>
    public class CheckInfo 
    {

        /// <summary>
        /// 符合条件的结果总数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 返回的结果总数。
        /// </summary>
        [JsonProperty("return_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReturnNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_item", NullValueHandling = NullValueHandling.Ignore)]
        public SearchAfterParam LastItem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckInfo {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  returnNum: ").Append(ReturnNum).Append("\n");
            sb.Append("  lastItem: ").Append(LastItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckInfo input)
        {
            if (input == null) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.ReturnNum != input.ReturnNum || (this.ReturnNum != null && !this.ReturnNum.Equals(input.ReturnNum))) return false;
            if (this.LastItem != input.LastItem || (this.LastItem != null && !this.LastItem.Equals(input.LastItem))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.ReturnNum != null) hashCode = hashCode * 59 + this.ReturnNum.GetHashCode();
                if (this.LastItem != null) hashCode = hashCode * 59 + this.LastItem.GetHashCode();
                return hashCode;
            }
        }
    }
}
