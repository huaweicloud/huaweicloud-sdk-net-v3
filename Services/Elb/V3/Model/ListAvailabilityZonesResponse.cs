using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailabilityZonesResponse : SdkResponse
    {

        /// <summary>
        /// 请求ID。  注：自动生成。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回创建LB时可使用的可用区集合列表。如：[[az1,az2],[az2,az3]] , 则在创建LB时，只能从其中的一个子列表中选择一个或多个可用区，不能跨列表选择。在上述例子中，不能选择az1和az3。
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<AvailabilityZone>> AvailabilityZones { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailabilityZonesResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailabilityZonesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailabilityZonesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.AvailabilityZones == input.AvailabilityZones ||
                    this.AvailabilityZones != null &&
                    input.AvailabilityZones != null &&
                    this.AvailabilityZones.SequenceEqual(input.AvailabilityZones)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.AvailabilityZones != null)
                    hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
