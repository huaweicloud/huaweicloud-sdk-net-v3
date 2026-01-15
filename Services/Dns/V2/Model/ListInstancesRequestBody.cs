using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListInstancesRequestBody 
    {

        /// <summary>
        /// **参数解释：** DNS批量查询接口支持查询的维度。 **约束限制：** 不涉及。 **取值范围：** - dns_public_zone_id：公网域名ID - dns_public_recordset_id：公网记录集ID，需与dns_public_zone_id组合使用 - dns_private_zone_id：内网域名ID - vpc_id：VPC ID，需与dns_private_zone_id组合使用 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("dim_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DimName { get; set; }

        /// <summary>
        /// DNS上报的资源ID列表。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<string>> Ids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRequestBody {\n");
            sb.Append("  dimName: ").Append(DimName).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRequestBody input)
        {
            if (input == null) return false;
            if (this.DimName != input.DimName || (this.DimName != null && input.DimName != null && !this.DimName.SequenceEqual(input.DimName))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;

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
                if (this.DimName != null) hashCode = hashCode * 59 + this.DimName.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                return hashCode;
            }
        }
    }
}
