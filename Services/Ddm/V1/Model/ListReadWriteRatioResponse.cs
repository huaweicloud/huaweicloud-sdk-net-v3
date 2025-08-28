using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListReadWriteRatioResponse : SdkResponse
    {

        /// <summary>
        /// DDM读写比例监控信息条数。
        /// </summary>
        [JsonProperty("totalRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecord { get; set; }

        /// <summary>
        /// DDM实例读写次数信息列表的集合。
        /// </summary>
        [JsonProperty("readWriteRatioList", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReadWriteRatioList> ReadWriteRatioList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReadWriteRatioResponse {\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("  readWriteRatioList: ").Append(ReadWriteRatioList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReadWriteRatioResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReadWriteRatioResponse input)
        {
            if (input == null) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;
            if (this.ReadWriteRatioList != input.ReadWriteRatioList || (this.ReadWriteRatioList != null && input.ReadWriteRatioList != null && !this.ReadWriteRatioList.SequenceEqual(input.ReadWriteRatioList))) return false;

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
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                if (this.ReadWriteRatioList != null) hashCode = hashCode * 59 + this.ReadWriteRatioList.GetHashCode();
                return hashCode;
            }
        }
    }
}
