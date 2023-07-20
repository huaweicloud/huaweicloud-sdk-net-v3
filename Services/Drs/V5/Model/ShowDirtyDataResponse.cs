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
    public class ShowDirtyDataResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 异常数据列表。
        /// </summary>
        [JsonProperty("dirty_data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DirtyData> DirtyDataList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDirtyDataResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  dirtyDataList: ").Append(DirtyDataList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDirtyDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDirtyDataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.DirtyDataList == input.DirtyDataList ||
                    this.DirtyDataList != null &&
                    input.DirtyDataList != null &&
                    this.DirtyDataList.SequenceEqual(input.DirtyDataList)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.DirtyDataList != null)
                    hashCode = hashCode * 59 + this.DirtyDataList.GetHashCode();
                return hashCode;
            }
        }
    }
}
