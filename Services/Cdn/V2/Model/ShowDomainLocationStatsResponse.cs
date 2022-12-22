using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDomainLocationStatsResponse : SdkResponse
    {

        /// <summary>
        /// 数据分组方式
        /// </summary>
        [JsonProperty("group_by", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupBy { get; set; }

        /// <summary>
        /// 按指定的分组方式组织的数据
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Result { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainLocationStatsResponse {\n");
            sb.Append("  groupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainLocationStatsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainLocationStatsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
