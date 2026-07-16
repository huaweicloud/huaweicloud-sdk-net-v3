using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 部署版本概要信息
    /// </summary>
    public class InferDeploymentVersionItemResp 
    {

        /// <summary>
        /// **参数解释：** 部署id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("infer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InferName { get; set; }

        /// <summary>
        /// **参数解释：** 部署版本 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 版本状态 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("version_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionStatus { get; set; }

        /// <summary>
        /// **参数解释：** 版本描述 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 部署类型。 **取值范围：** - SINGLE：单机单卡。 - MULTI：多机多卡。
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferDeploymentVersionItemResp {\n");
            sb.Append("  inferName: ").Append(InferName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionStatus: ").Append(VersionStatus).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferDeploymentVersionItemResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferDeploymentVersionItemResp input)
        {
            if (input == null) return false;
            if (this.InferName != input.InferName || (this.InferName != null && !this.InferName.Equals(input.InferName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionStatus != input.VersionStatus || (this.VersionStatus != null && !this.VersionStatus.Equals(input.VersionStatus))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;

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
                if (this.InferName != null) hashCode = hashCode * 59 + this.InferName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionStatus != null) hashCode = hashCode * 59 + this.VersionStatus.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                return hashCode;
            }
        }
    }
}
