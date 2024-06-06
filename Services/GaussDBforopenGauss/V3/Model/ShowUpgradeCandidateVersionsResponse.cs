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
    public class ShowUpgradeCandidateVersionsResponse : SdkResponse
    {

        /// <summary>
        /// 升级类型信息列表
        /// </summary>
        [JsonProperty("upgrade_type_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeTypeInfo> UpgradeTypeList { get; set; }

        /// <summary>
        /// 是否可以回滚，true可以回滚，false不可以回滚
        /// </summary>
        [JsonProperty("rollback_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RollbackEnabled { get; set; }

        /// <summary>
        /// 原版本
        /// </summary>
        [JsonProperty("source_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// 升级目标版本，没有在滚动升级中返回null
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("roll_upgrade_progress", NullValueHandling = NullValueHandling.Ignore)]
        public RollUpgradeProgress RollUpgradeProgress { get; set; }

        /// <summary>
        /// 可以升级的版本，包括大小版本，滚动升级中返回空数组
        /// </summary>
        [JsonProperty("upgrade_candidate_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpgradeCandidateVersions { get; set; }

        /// <summary>
        /// 可以升级的热补丁版本，滚动升级中返回空数组
        /// </summary>
        [JsonProperty("hotfix_upgrade_candidate_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HotfixUpgradeCandidateVersions { get; set; }

        /// <summary>
        /// 可以回滚的热补丁版本，滚动升级中返回空数组
        /// </summary>
        [JsonProperty("hotfix_rollback_candidate_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HotfixRollbackCandidateVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hotfix_upgrade_infos", NullValueHandling = NullValueHandling.Ignore)]
        public HotfixUpgradeInfos HotfixUpgradeInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hotfix_rollback_infos", NullValueHandling = NullValueHandling.Ignore)]
        public HotfixRollbackInfos HotfixRollbackInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUpgradeCandidateVersionsResponse {\n");
            sb.Append("  upgradeTypeList: ").Append(UpgradeTypeList).Append("\n");
            sb.Append("  rollbackEnabled: ").Append(RollbackEnabled).Append("\n");
            sb.Append("  sourceVersion: ").Append(SourceVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  rollUpgradeProgress: ").Append(RollUpgradeProgress).Append("\n");
            sb.Append("  upgradeCandidateVersions: ").Append(UpgradeCandidateVersions).Append("\n");
            sb.Append("  hotfixUpgradeCandidateVersions: ").Append(HotfixUpgradeCandidateVersions).Append("\n");
            sb.Append("  hotfixRollbackCandidateVersions: ").Append(HotfixRollbackCandidateVersions).Append("\n");
            sb.Append("  hotfixUpgradeInfos: ").Append(HotfixUpgradeInfos).Append("\n");
            sb.Append("  hotfixRollbackInfos: ").Append(HotfixRollbackInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUpgradeCandidateVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUpgradeCandidateVersionsResponse input)
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
                    this.RollbackEnabled == input.RollbackEnabled ||
                    (this.RollbackEnabled != null &&
                    this.RollbackEnabled.Equals(input.RollbackEnabled))
                ) && 
                (
                    this.SourceVersion == input.SourceVersion ||
                    (this.SourceVersion != null &&
                    this.SourceVersion.Equals(input.SourceVersion))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.RollUpgradeProgress == input.RollUpgradeProgress ||
                    (this.RollUpgradeProgress != null &&
                    this.RollUpgradeProgress.Equals(input.RollUpgradeProgress))
                ) && 
                (
                    this.UpgradeCandidateVersions == input.UpgradeCandidateVersions ||
                    this.UpgradeCandidateVersions != null &&
                    input.UpgradeCandidateVersions != null &&
                    this.UpgradeCandidateVersions.SequenceEqual(input.UpgradeCandidateVersions)
                ) && 
                (
                    this.HotfixUpgradeCandidateVersions == input.HotfixUpgradeCandidateVersions ||
                    this.HotfixUpgradeCandidateVersions != null &&
                    input.HotfixUpgradeCandidateVersions != null &&
                    this.HotfixUpgradeCandidateVersions.SequenceEqual(input.HotfixUpgradeCandidateVersions)
                ) && 
                (
                    this.HotfixRollbackCandidateVersions == input.HotfixRollbackCandidateVersions ||
                    this.HotfixRollbackCandidateVersions != null &&
                    input.HotfixRollbackCandidateVersions != null &&
                    this.HotfixRollbackCandidateVersions.SequenceEqual(input.HotfixRollbackCandidateVersions)
                ) && 
                (
                    this.HotfixUpgradeInfos == input.HotfixUpgradeInfos ||
                    (this.HotfixUpgradeInfos != null &&
                    this.HotfixUpgradeInfos.Equals(input.HotfixUpgradeInfos))
                ) && 
                (
                    this.HotfixRollbackInfos == input.HotfixRollbackInfos ||
                    (this.HotfixRollbackInfos != null &&
                    this.HotfixRollbackInfos.Equals(input.HotfixRollbackInfos))
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
                if (this.RollbackEnabled != null)
                    hashCode = hashCode * 59 + this.RollbackEnabled.GetHashCode();
                if (this.SourceVersion != null)
                    hashCode = hashCode * 59 + this.SourceVersion.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.RollUpgradeProgress != null)
                    hashCode = hashCode * 59 + this.RollUpgradeProgress.GetHashCode();
                if (this.UpgradeCandidateVersions != null)
                    hashCode = hashCode * 59 + this.UpgradeCandidateVersions.GetHashCode();
                if (this.HotfixUpgradeCandidateVersions != null)
                    hashCode = hashCode * 59 + this.HotfixUpgradeCandidateVersions.GetHashCode();
                if (this.HotfixRollbackCandidateVersions != null)
                    hashCode = hashCode * 59 + this.HotfixRollbackCandidateVersions.GetHashCode();
                if (this.HotfixUpgradeInfos != null)
                    hashCode = hashCode * 59 + this.HotfixUpgradeInfos.GetHashCode();
                if (this.HotfixRollbackInfos != null)
                    hashCode = hashCode * 59 + this.HotfixRollbackInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
