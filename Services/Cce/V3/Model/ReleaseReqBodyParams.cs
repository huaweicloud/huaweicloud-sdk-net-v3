using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 模板实例参数
    /// </summary>
    public class ReleaseReqBodyParams 
    {

        /// <summary>
        /// 开启后，仅验证模板参数，不进行安装
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 实例名称模板
        /// </summary>
        [JsonProperty("name_template", NullValueHandling = NullValueHandling.Ignore)]
        public string NameTemplate { get; set; }

        /// <summary>
        /// 安装时是否禁用hooks
        /// </summary>
        [JsonProperty("no_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoHooks { get; set; }

        /// <summary>
        /// 是否替换同名实例
        /// </summary>
        [JsonProperty("replace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Replace { get; set; }

        /// <summary>
        /// 是否重建实例
        /// </summary>
        [JsonProperty("recreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recreate { get; set; }

        /// <summary>
        /// 更新时是否重置values
        /// </summary>
        [JsonProperty("reset_values", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetValues { get; set; }

        /// <summary>
        /// 回滚实例的版本
        /// </summary>
        [JsonProperty("release_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseVersion { get; set; }

        /// <summary>
        /// 更新或者删除时启用hooks
        /// </summary>
        [JsonProperty("include_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeHooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseReqBodyParams {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  nameTemplate: ").Append(NameTemplate).Append("\n");
            sb.Append("  noHooks: ").Append(NoHooks).Append("\n");
            sb.Append("  replace: ").Append(Replace).Append("\n");
            sb.Append("  recreate: ").Append(Recreate).Append("\n");
            sb.Append("  resetValues: ").Append(ResetValues).Append("\n");
            sb.Append("  releaseVersion: ").Append(ReleaseVersion).Append("\n");
            sb.Append("  includeHooks: ").Append(IncludeHooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReleaseReqBodyParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReleaseReqBodyParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
                ) && 
                (
                    this.NameTemplate == input.NameTemplate ||
                    (this.NameTemplate != null &&
                    this.NameTemplate.Equals(input.NameTemplate))
                ) && 
                (
                    this.NoHooks == input.NoHooks ||
                    (this.NoHooks != null &&
                    this.NoHooks.Equals(input.NoHooks))
                ) && 
                (
                    this.Replace == input.Replace ||
                    (this.Replace != null &&
                    this.Replace.Equals(input.Replace))
                ) && 
                (
                    this.Recreate == input.Recreate ||
                    (this.Recreate != null &&
                    this.Recreate.Equals(input.Recreate))
                ) && 
                (
                    this.ResetValues == input.ResetValues ||
                    (this.ResetValues != null &&
                    this.ResetValues.Equals(input.ResetValues))
                ) && 
                (
                    this.ReleaseVersion == input.ReleaseVersion ||
                    (this.ReleaseVersion != null &&
                    this.ReleaseVersion.Equals(input.ReleaseVersion))
                ) && 
                (
                    this.IncludeHooks == input.IncludeHooks ||
                    (this.IncludeHooks != null &&
                    this.IncludeHooks.Equals(input.IncludeHooks))
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
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.NameTemplate != null)
                    hashCode = hashCode * 59 + this.NameTemplate.GetHashCode();
                if (this.NoHooks != null)
                    hashCode = hashCode * 59 + this.NoHooks.GetHashCode();
                if (this.Replace != null)
                    hashCode = hashCode * 59 + this.Replace.GetHashCode();
                if (this.Recreate != null)
                    hashCode = hashCode * 59 + this.Recreate.GetHashCode();
                if (this.ResetValues != null)
                    hashCode = hashCode * 59 + this.ResetValues.GetHashCode();
                if (this.ReleaseVersion != null)
                    hashCode = hashCode * 59 + this.ReleaseVersion.GetHashCode();
                if (this.IncludeHooks != null)
                    hashCode = hashCode * 59 + this.IncludeHooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
