using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Overview 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_policies", NullValueHandling = NullValueHandling.Ignore)]
        public AccessPolicy AccessPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public ChangedVO Assets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attack_event", NullValueHandling = NullValueHandling.Ignore)]
        public AttackEvent AttackEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_peak", NullValueHandling = NullValueHandling.Ignore)]
        public TrendVO TrafficPeak { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Overview {\n");
            sb.Append("  accessPolicies: ").Append(AccessPolicies).Append("\n");
            sb.Append("  assets: ").Append(Assets).Append("\n");
            sb.Append("  attackEvent: ").Append(AttackEvent).Append("\n");
            sb.Append("  trafficPeak: ").Append(TrafficPeak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Overview);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Overview input)
        {
            if (input == null) return false;
            if (this.AccessPolicies != input.AccessPolicies || (this.AccessPolicies != null && !this.AccessPolicies.Equals(input.AccessPolicies))) return false;
            if (this.Assets != input.Assets || (this.Assets != null && !this.Assets.Equals(input.Assets))) return false;
            if (this.AttackEvent != input.AttackEvent || (this.AttackEvent != null && !this.AttackEvent.Equals(input.AttackEvent))) return false;
            if (this.TrafficPeak != input.TrafficPeak || (this.TrafficPeak != null && !this.TrafficPeak.Equals(input.TrafficPeak))) return false;

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
                if (this.AccessPolicies != null) hashCode = hashCode * 59 + this.AccessPolicies.GetHashCode();
                if (this.Assets != null) hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.AttackEvent != null) hashCode = hashCode * 59 + this.AttackEvent.GetHashCode();
                if (this.TrafficPeak != null) hashCode = hashCode * 59 + this.TrafficPeak.GetHashCode();
                return hashCode;
            }
        }
    }
}
