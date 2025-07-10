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
    public class ShowLandingZoneStatusResponse : SdkResponse
    {

        /// <summary>
        /// 部署的Landing Zone版本。
        /// </summary>
        [JsonProperty("deployed_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployedVersion { get; set; }

        /// <summary>
        /// Landing Zone的设置状态，包括进行中，已完成。
        /// </summary>
        [JsonProperty("landing_zone_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LandingZoneStatus { get; set; }

        /// <summary>
        /// Landing Zone的完成进度。
        /// </summary>
        [JsonProperty("percentage_complete", NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageComplete { get; set; }

        /// <summary>
        /// Landing Zone设置的详细进度信息。
        /// </summary>
        [JsonProperty("percentage_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<PercentageDetail> PercentageDetails { get; set; }

        /// <summary>
        /// Landing Zone当前需要执行的动作。
        /// </summary>
        [JsonProperty("landing_zone_action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LandingZoneActionType { get; set; }

        /// <summary>
        /// Landing Zone错误消息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public List<LandingZoneErrorMessage> Message { get; set; }

        /// <summary>
        /// 纳管的区域信息。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionConfigurationList> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLandingZoneStatusResponse {\n");
            sb.Append("  deployedVersion: ").Append(DeployedVersion).Append("\n");
            sb.Append("  landingZoneStatus: ").Append(LandingZoneStatus).Append("\n");
            sb.Append("  percentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  percentageDetails: ").Append(PercentageDetails).Append("\n");
            sb.Append("  landingZoneActionType: ").Append(LandingZoneActionType).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLandingZoneStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLandingZoneStatusResponse input)
        {
            if (input == null) return false;
            if (this.DeployedVersion != input.DeployedVersion || (this.DeployedVersion != null && !this.DeployedVersion.Equals(input.DeployedVersion))) return false;
            if (this.LandingZoneStatus != input.LandingZoneStatus || (this.LandingZoneStatus != null && !this.LandingZoneStatus.Equals(input.LandingZoneStatus))) return false;
            if (this.PercentageComplete != input.PercentageComplete || (this.PercentageComplete != null && !this.PercentageComplete.Equals(input.PercentageComplete))) return false;
            if (this.PercentageDetails != input.PercentageDetails || (this.PercentageDetails != null && input.PercentageDetails != null && !this.PercentageDetails.SequenceEqual(input.PercentageDetails))) return false;
            if (this.LandingZoneActionType != input.LandingZoneActionType || (this.LandingZoneActionType != null && !this.LandingZoneActionType.Equals(input.LandingZoneActionType))) return false;
            if (this.Message != input.Message || (this.Message != null && input.Message != null && !this.Message.SequenceEqual(input.Message))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.DeployedVersion != null) hashCode = hashCode * 59 + this.DeployedVersion.GetHashCode();
                if (this.LandingZoneStatus != null) hashCode = hashCode * 59 + this.LandingZoneStatus.GetHashCode();
                if (this.PercentageComplete != null) hashCode = hashCode * 59 + this.PercentageComplete.GetHashCode();
                if (this.PercentageDetails != null) hashCode = hashCode * 59 + this.PercentageDetails.GetHashCode();
                if (this.LandingZoneActionType != null) hashCode = hashCode * 59 + this.LandingZoneActionType.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
