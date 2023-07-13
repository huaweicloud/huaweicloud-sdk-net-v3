using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailableFlavorInfosResponse : SdkResponse
    {

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("current_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public ComputeFlavor CurrentFlavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("optional_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public OptionalFlavorsInfo OptionalFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailableFlavorInfosResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  currentFlavor: ").Append(CurrentFlavor).Append("\n");
            sb.Append("  optionalFlavors: ").Append(OptionalFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailableFlavorInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailableFlavorInfosResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.CurrentFlavor == input.CurrentFlavor ||
                    (this.CurrentFlavor != null &&
                    this.CurrentFlavor.Equals(input.CurrentFlavor))
                ) && 
                (
                    this.OptionalFlavors == input.OptionalFlavors ||
                    (this.OptionalFlavors != null &&
                    this.OptionalFlavors.Equals(input.OptionalFlavors))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.CurrentFlavor != null)
                    hashCode = hashCode * 59 + this.CurrentFlavor.GetHashCode();
                if (this.OptionalFlavors != null)
                    hashCode = hashCode * 59 + this.OptionalFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
