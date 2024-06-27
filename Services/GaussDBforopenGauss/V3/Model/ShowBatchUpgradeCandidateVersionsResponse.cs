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
    /// Response Object
    /// </summary>
    public class ShowBatchUpgradeCandidateVersionsResponse : SdkResponse
    {

        /// <summary>
        /// 升级类型信息列表
        /// </summary>
        [JsonProperty("upgrade_type_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeTypeInfo> UpgradeTypeList { get; set; }

        /// <summary>
        /// 升级目标版本，没有在滚动升级中返回null
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 可以升级的版本，包括大小版本
        /// </summary>
        [JsonProperty("upgrade_candidate_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpgradeCandidateVersions { get; set; }

        /// <summary>
        /// 可以升级的热补丁信息
        /// </summary>
        [JsonProperty("hotfix_upgrade_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<HotfixInfo> HotfixUpgradeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBatchUpgradeCandidateVersionsResponse {\n");
            sb.Append("  upgradeTypeList: ").Append(UpgradeTypeList).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  upgradeCandidateVersions: ").Append(UpgradeCandidateVersions).Append("\n");
            sb.Append("  hotfixUpgradeInfos: ").Append(HotfixUpgradeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBatchUpgradeCandidateVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBatchUpgradeCandidateVersionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpgradeTypeList == input.UpgradeTypeList ||
                    this.UpgradeTypeList != null &&
                    input.UpgradeTypeList != null &&
                    this.UpgradeTypeList.SequenceEqual(input.UpgradeTypeList)
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.UpgradeCandidateVersions == input.UpgradeCandidateVersions ||
                    this.UpgradeCandidateVersions != null &&
                    input.UpgradeCandidateVersions != null &&
                    this.UpgradeCandidateVersions.SequenceEqual(input.UpgradeCandidateVersions)
                ) && 
                (
                    this.HotfixUpgradeInfos == input.HotfixUpgradeInfos ||
                    this.HotfixUpgradeInfos != null &&
                    input.HotfixUpgradeInfos != null &&
                    this.HotfixUpgradeInfos.SequenceEqual(input.HotfixUpgradeInfos)
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
                if (this.UpgradeTypeList != null)
                    hashCode = hashCode * 59 + this.UpgradeTypeList.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.UpgradeCandidateVersions != null)
                    hashCode = hashCode * 59 + this.UpgradeCandidateVersions.GetHashCode();
                if (this.HotfixUpgradeInfos != null)
                    hashCode = hashCode * 59 + this.HotfixUpgradeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
