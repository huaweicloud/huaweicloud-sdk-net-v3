using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReleaseParams 
    {

        /// <summary>
        /// 是否仅模拟安装过程
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 是否允许重用已存在的名称
        /// </summary>
        [JsonProperty("replace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Replace { get; set; }

        /// <summary>
        /// 是否强制重新创建资源
        /// </summary>
        [JsonProperty("recreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recreate { get; set; }

        /// <summary>
        /// 是否禁止hook
        /// </summary>
        [JsonProperty("no_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoHooks { get; set; }

        /// <summary>
        /// 更新时重设values
        /// </summary>
        [JsonProperty("reset_values", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetValues { get; set; }

        /// <summary>
        /// 发布资源的名称模板
        /// </summary>
        [JsonProperty("name_template", NullValueHandling = NullValueHandling.Ignore)]
        public string NameTemplate { get; set; }

        /// <summary>
        /// 指定回滚版本号
        /// </summary>
        [JsonProperty("release_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseVersion { get; set; }

        /// <summary>
        /// 更新或删除时是否允许hook
        /// </summary>
        [JsonProperty("include_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeHooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseParams {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  replace: ").Append(Replace).Append("\n");
            sb.Append("  recreate: ").Append(Recreate).Append("\n");
            sb.Append("  noHooks: ").Append(NoHooks).Append("\n");
            sb.Append("  resetValues: ").Append(ResetValues).Append("\n");
            sb.Append("  nameTemplate: ").Append(NameTemplate).Append("\n");
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
            return this.Equals(input as ReleaseParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReleaseParams input)
        {
            if (input == null) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;
            if (this.Replace != input.Replace || (this.Replace != null && !this.Replace.Equals(input.Replace))) return false;
            if (this.Recreate != input.Recreate || (this.Recreate != null && !this.Recreate.Equals(input.Recreate))) return false;
            if (this.NoHooks != input.NoHooks || (this.NoHooks != null && !this.NoHooks.Equals(input.NoHooks))) return false;
            if (this.ResetValues != input.ResetValues || (this.ResetValues != null && !this.ResetValues.Equals(input.ResetValues))) return false;
            if (this.NameTemplate != input.NameTemplate || (this.NameTemplate != null && !this.NameTemplate.Equals(input.NameTemplate))) return false;
            if (this.ReleaseVersion != input.ReleaseVersion || (this.ReleaseVersion != null && !this.ReleaseVersion.Equals(input.ReleaseVersion))) return false;
            if (this.IncludeHooks != input.IncludeHooks || (this.IncludeHooks != null && !this.IncludeHooks.Equals(input.IncludeHooks))) return false;

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
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.Replace != null) hashCode = hashCode * 59 + this.Replace.GetHashCode();
                if (this.Recreate != null) hashCode = hashCode * 59 + this.Recreate.GetHashCode();
                if (this.NoHooks != null) hashCode = hashCode * 59 + this.NoHooks.GetHashCode();
                if (this.ResetValues != null) hashCode = hashCode * 59 + this.ResetValues.GetHashCode();
                if (this.NameTemplate != null) hashCode = hashCode * 59 + this.NameTemplate.GetHashCode();
                if (this.ReleaseVersion != null) hashCode = hashCode * 59 + this.ReleaseVersion.GetHashCode();
                if (this.IncludeHooks != null) hashCode = hashCode * 59 + this.IncludeHooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
