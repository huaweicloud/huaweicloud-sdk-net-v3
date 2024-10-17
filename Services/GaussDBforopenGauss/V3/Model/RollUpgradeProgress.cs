using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 滚动升级信息。
    /// </summary>
    public class RollUpgradeProgress 
    {

        /// <summary>
        /// 已升级分片数，非独立部署返回null。
        /// </summary>
        [JsonProperty("upgraded_dn_group_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradedDnGroupNumbers { get; set; }

        /// <summary>
        /// 总分片数，非独立部署返回null。
        /// </summary>
        [JsonProperty("total_dn_group_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDnGroupNumbers { get; set; }

        /// <summary>
        /// 未完成升级的az，以“,”隔开，独立部署返回null。
        /// </summary>
        [JsonProperty("not_fully_upgraded_az", NullValueHandling = NullValueHandling.Ignore)]
        public string NotFullyUpgradedAz { get; set; }

        /// <summary>
        /// 已升级az，以“,”隔开，独立部署返回null。
        /// </summary>
        [JsonProperty("already_upgraded_az", NullValueHandling = NullValueHandling.Ignore)]
        public string AlreadyUpgradedAz { get; set; }

        /// <summary>
        /// az描述键值对Map&lt;String,String&gt;。
        /// </summary>
        [JsonProperty("az_description_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzDescriptionMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollUpgradeProgress {\n");
            sb.Append("  upgradedDnGroupNumbers: ").Append(UpgradedDnGroupNumbers).Append("\n");
            sb.Append("  totalDnGroupNumbers: ").Append(TotalDnGroupNumbers).Append("\n");
            sb.Append("  notFullyUpgradedAz: ").Append(NotFullyUpgradedAz).Append("\n");
            sb.Append("  alreadyUpgradedAz: ").Append(AlreadyUpgradedAz).Append("\n");
            sb.Append("  azDescriptionMap: ").Append(AzDescriptionMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RollUpgradeProgress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RollUpgradeProgress input)
        {
            if (input == null) return false;
            if (this.UpgradedDnGroupNumbers != input.UpgradedDnGroupNumbers || (this.UpgradedDnGroupNumbers != null && !this.UpgradedDnGroupNumbers.Equals(input.UpgradedDnGroupNumbers))) return false;
            if (this.TotalDnGroupNumbers != input.TotalDnGroupNumbers || (this.TotalDnGroupNumbers != null && !this.TotalDnGroupNumbers.Equals(input.TotalDnGroupNumbers))) return false;
            if (this.NotFullyUpgradedAz != input.NotFullyUpgradedAz || (this.NotFullyUpgradedAz != null && !this.NotFullyUpgradedAz.Equals(input.NotFullyUpgradedAz))) return false;
            if (this.AlreadyUpgradedAz != input.AlreadyUpgradedAz || (this.AlreadyUpgradedAz != null && !this.AlreadyUpgradedAz.Equals(input.AlreadyUpgradedAz))) return false;
            if (this.AzDescriptionMap != input.AzDescriptionMap || (this.AzDescriptionMap != null && input.AzDescriptionMap != null && !this.AzDescriptionMap.SequenceEqual(input.AzDescriptionMap))) return false;

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
                if (this.UpgradedDnGroupNumbers != null) hashCode = hashCode * 59 + this.UpgradedDnGroupNumbers.GetHashCode();
                if (this.TotalDnGroupNumbers != null) hashCode = hashCode * 59 + this.TotalDnGroupNumbers.GetHashCode();
                if (this.NotFullyUpgradedAz != null) hashCode = hashCode * 59 + this.NotFullyUpgradedAz.GetHashCode();
                if (this.AlreadyUpgradedAz != null) hashCode = hashCode * 59 + this.AlreadyUpgradedAz.GetHashCode();
                if (this.AzDescriptionMap != null) hashCode = hashCode * 59 + this.AzDescriptionMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
