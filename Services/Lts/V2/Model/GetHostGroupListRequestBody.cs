using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetHostGroupListRequestBody 
    {

        /// <summary>
        /// 主机组ID
        /// </summary>
        [JsonProperty("host_group_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostGroupIdList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public GetHostGroupListFilter Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostGroupListRequestBody {\n");
            sb.Append("  hostGroupIdList: ").Append(HostGroupIdList).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostGroupListRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostGroupListRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostGroupIdList == input.HostGroupIdList ||
                    this.HostGroupIdList != null &&
                    input.HostGroupIdList != null &&
                    this.HostGroupIdList.SequenceEqual(input.HostGroupIdList)
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.HostGroupIdList != null)
                    hashCode = hashCode * 59 + this.HostGroupIdList.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
