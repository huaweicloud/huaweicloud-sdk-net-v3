using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAvailableResourceRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("flavor_id", IsQuery = true)]
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FlavorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dec_project_id", IsQuery = true)]
        [JsonProperty("dec_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DecProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("check_limit", IsQuery = true)]
        [JsonProperty("check_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CheckLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("expectation", IsQuery = true)]
        [JsonProperty("expectation", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Expectation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvailableResourceRequest {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  decProjectId: ").Append(DecProjectId).Append("\n");
            sb.Append("  checkLimit: ").Append(CheckLimit).Append("\n");
            sb.Append("  expectation: ").Append(Expectation).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvailableResourceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvailableResourceRequest input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && input.AvailabilityZone != null && !this.AvailabilityZone.SequenceEqual(input.AvailabilityZone))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && input.FlavorId != null && !this.FlavorId.SequenceEqual(input.FlavorId))) return false;
            if (this.DecProjectId != input.DecProjectId || (this.DecProjectId != null && input.DecProjectId != null && !this.DecProjectId.SequenceEqual(input.DecProjectId))) return false;
            if (this.CheckLimit != input.CheckLimit || (this.CheckLimit != null && input.CheckLimit != null && !this.CheckLimit.SequenceEqual(input.CheckLimit))) return false;
            if (this.Expectation != input.Expectation || (this.Expectation != null && input.Expectation != null && !this.Expectation.SequenceEqual(input.Expectation))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && input.ResourceType != null && !this.ResourceType.SequenceEqual(input.ResourceType))) return false;

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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.DecProjectId != null) hashCode = hashCode * 59 + this.DecProjectId.GetHashCode();
                if (this.CheckLimit != null) hashCode = hashCode * 59 + this.CheckLimit.GetHashCode();
                if (this.Expectation != null) hashCode = hashCode * 59 + this.Expectation.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
