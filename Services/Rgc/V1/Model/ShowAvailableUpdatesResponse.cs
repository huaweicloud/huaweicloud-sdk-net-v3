using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAvailableUpdatesResponse : SdkResponse
    {

        /// <summary>
        /// 用户当前的Landing Zone版本是否为最新版本。
        /// </summary>
        [JsonProperty("baseline_update_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BaselineUpdateAvailable { get; set; }

        /// <summary>
        /// 当前账号下是否有新的控制策略。
        /// </summary>
        [JsonProperty("control_update_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ControlUpdateAvailable { get; set; }

        /// <summary>
        /// Landing Zone是否可更新。
        /// </summary>
        [JsonProperty("landing_zone_update_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LandingZoneUpdateAvailable { get; set; }

        /// <summary>
        /// Landing Zone当前最新的版本号。
        /// </summary>
        [JsonProperty("service_landing_zone_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceLandingZoneVersion { get; set; }

        /// <summary>
        /// 用户当前的Landing Zone版本。
        /// </summary>
        [JsonProperty("user_landing_zone_version", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLandingZoneVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvailableUpdatesResponse {\n");
            sb.Append("  baselineUpdateAvailable: ").Append(BaselineUpdateAvailable).Append("\n");
            sb.Append("  controlUpdateAvailable: ").Append(ControlUpdateAvailable).Append("\n");
            sb.Append("  landingZoneUpdateAvailable: ").Append(LandingZoneUpdateAvailable).Append("\n");
            sb.Append("  serviceLandingZoneVersion: ").Append(ServiceLandingZoneVersion).Append("\n");
            sb.Append("  userLandingZoneVersion: ").Append(UserLandingZoneVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvailableUpdatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvailableUpdatesResponse input)
        {
            if (input == null) return false;
            if (this.BaselineUpdateAvailable != input.BaselineUpdateAvailable || (this.BaselineUpdateAvailable != null && !this.BaselineUpdateAvailable.Equals(input.BaselineUpdateAvailable))) return false;
            if (this.ControlUpdateAvailable != input.ControlUpdateAvailable || (this.ControlUpdateAvailable != null && !this.ControlUpdateAvailable.Equals(input.ControlUpdateAvailable))) return false;
            if (this.LandingZoneUpdateAvailable != input.LandingZoneUpdateAvailable || (this.LandingZoneUpdateAvailable != null && !this.LandingZoneUpdateAvailable.Equals(input.LandingZoneUpdateAvailable))) return false;
            if (this.ServiceLandingZoneVersion != input.ServiceLandingZoneVersion || (this.ServiceLandingZoneVersion != null && !this.ServiceLandingZoneVersion.Equals(input.ServiceLandingZoneVersion))) return false;
            if (this.UserLandingZoneVersion != input.UserLandingZoneVersion || (this.UserLandingZoneVersion != null && !this.UserLandingZoneVersion.Equals(input.UserLandingZoneVersion))) return false;

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
                if (this.BaselineUpdateAvailable != null) hashCode = hashCode * 59 + this.BaselineUpdateAvailable.GetHashCode();
                if (this.ControlUpdateAvailable != null) hashCode = hashCode * 59 + this.ControlUpdateAvailable.GetHashCode();
                if (this.LandingZoneUpdateAvailable != null) hashCode = hashCode * 59 + this.LandingZoneUpdateAvailable.GetHashCode();
                if (this.ServiceLandingZoneVersion != null) hashCode = hashCode * 59 + this.ServiceLandingZoneVersion.GetHashCode();
                if (this.UserLandingZoneVersion != null) hashCode = hashCode * 59 + this.UserLandingZoneVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
