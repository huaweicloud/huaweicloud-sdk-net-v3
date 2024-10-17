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
    public class ShowObjectMappingResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 同步映射数据列表。
        /// </summary>
        [JsonProperty("object_mapping_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbObjectInfo> ObjectMappingList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowObjectMappingResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  objectMappingList: ").Append(ObjectMappingList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowObjectMappingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowObjectMappingResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ObjectMappingList != input.ObjectMappingList || (this.ObjectMappingList != null && input.ObjectMappingList != null && !this.ObjectMappingList.SequenceEqual(input.ObjectMappingList))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ObjectMappingList != null) hashCode = hashCode * 59 + this.ObjectMappingList.GetHashCode();
                return hashCode;
            }
        }
    }
}
