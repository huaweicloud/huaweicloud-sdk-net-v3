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
    /// 删除结果的相关信息。
    /// </summary>
    public class DeleteInfo 
    {

        /// <summary>
        /// 符合条件的结果总数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 本次删除的结果总数，目前一次请求最多删除100条结果。
        /// </summary>
        [JsonProperty("delete_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInfo {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  deleteNum: ").Append(DeleteNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
                ) && 
                (
                    this.DeleteNum == input.DeleteNum ||
                    (this.DeleteNum != null &&
                    this.DeleteNum.Equals(input.DeleteNum))
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
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.DeleteNum != null)
                    hashCode = hashCode * 59 + this.DeleteNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
