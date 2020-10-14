using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAllDCSInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 实例个数。
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 实例的详情数组。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceListInfo> Instances { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllDCSInstancesResponse {\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllDCSInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllDCSInstancesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceNum == input.InstanceNum ||
                    (this.InstanceNum != null &&
                    this.InstanceNum.Equals(input.InstanceNum))
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
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
                if (this.InstanceNum != null)
                    hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                return hashCode;
            }
        }
    }
}
