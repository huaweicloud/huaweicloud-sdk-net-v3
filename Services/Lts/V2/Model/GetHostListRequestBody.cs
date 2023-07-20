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
    /// 查询主机信息请求体
    /// </summary>
    public class GetHostListRequestBody 
    {

        /// <summary>
        /// 主机ID列表。可以根据主机ID列表进行批量过滤
        /// </summary>
        [JsonProperty("host_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIdList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public GetHostListFilter Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostListRequestBody {\n");
            sb.Append("  hostIdList: ").Append(HostIdList).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostListRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostListRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostIdList == input.HostIdList ||
                    this.HostIdList != null &&
                    input.HostIdList != null &&
                    this.HostIdList.SequenceEqual(input.HostIdList)
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
                if (this.HostIdList != null)
                    hashCode = hashCode * 59 + this.HostIdList.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
