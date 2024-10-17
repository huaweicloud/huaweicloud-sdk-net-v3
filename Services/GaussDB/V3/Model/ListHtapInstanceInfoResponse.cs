using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHtapInstanceInfoResponse : SdkResponse
    {

        /// <summary>
        /// HTAP实例个数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// HTAP实例信息。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<HtapInstanceListInstances> Instances { get; set; }

        /// <summary>
        /// 最大HTAP实例个数。
        /// </summary>
        [JsonProperty("max_htap_instance_num_of_taurus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxHtapInstanceNumOfTaurus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHtapInstanceInfoResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  maxHtapInstanceNumOfTaurus: ").Append(MaxHtapInstanceNumOfTaurus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHtapInstanceInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHtapInstanceInfoResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.MaxHtapInstanceNumOfTaurus != input.MaxHtapInstanceNumOfTaurus || (this.MaxHtapInstanceNumOfTaurus != null && !this.MaxHtapInstanceNumOfTaurus.Equals(input.MaxHtapInstanceNumOfTaurus))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.MaxHtapInstanceNumOfTaurus != null) hashCode = hashCode * 59 + this.MaxHtapInstanceNumOfTaurus.GetHashCode();
                return hashCode;
            }
        }
    }
}
