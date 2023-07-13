using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListFlavorSellPoliciesResult 
    {

        /// <summary>
        /// 云服务器规格的索引。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 云服务器规格的ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 云服务器规格的售卖状态。  sellout：售罄。 available：可用。
        /// </summary>
        [JsonProperty("sell_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SellStatus { get; set; }

        /// <summary>
        /// 云服务器规格的可用区。
        /// </summary>
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 云服务器规格的付费模式。  - postPaid：按需计费实例。 - prePaid：包年/包月计费实例。 - spot：竞价实例。 - ri：预留实例。
        /// </summary>
        [JsonProperty("sell_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string SellMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spot_options", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorSpotOptions SpotOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorSellPoliciesResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  sellStatus: ").Append(SellStatus).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  sellMode: ").Append(SellMode).Append("\n");
            sb.Append("  spotOptions: ").Append(SpotOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorSellPoliciesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorSellPoliciesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FlavorId == input.FlavorId ||
                    (this.FlavorId != null &&
                    this.FlavorId.Equals(input.FlavorId))
                ) && 
                (
                    this.SellStatus == input.SellStatus ||
                    (this.SellStatus != null &&
                    this.SellStatus.Equals(input.SellStatus))
                ) && 
                (
                    this.AvailabilityZoneId == input.AvailabilityZoneId ||
                    (this.AvailabilityZoneId != null &&
                    this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))
                ) && 
                (
                    this.SellMode == input.SellMode ||
                    (this.SellMode != null &&
                    this.SellMode.Equals(input.SellMode))
                ) && 
                (
                    this.SpotOptions == input.SpotOptions ||
                    (this.SpotOptions != null &&
                    this.SpotOptions.Equals(input.SpotOptions))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FlavorId != null)
                    hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.SellStatus != null)
                    hashCode = hashCode * 59 + this.SellStatus.GetHashCode();
                if (this.AvailabilityZoneId != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.SellMode != null)
                    hashCode = hashCode * 59 + this.SellMode.GetHashCode();
                if (this.SpotOptions != null)
                    hashCode = hashCode * 59 + this.SpotOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
