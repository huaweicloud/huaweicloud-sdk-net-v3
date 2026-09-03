using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 更新技能包信息请求。
    /// </summary>
    public class UpdateSkillPackageReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_status", NullValueHandling = NullValueHandling.Ignore)]
        public PackageStatusEnum? PackageStatus { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSkillPackageReq {\n");
            sb.Append("  packageStatus: ").Append(PackageStatus).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSkillPackageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSkillPackageReq input)
        {
            if (input == null) return false;
            if (this.PackageStatus != input.PackageStatus || (this.PackageStatus != null && !this.PackageStatus.Equals(input.PackageStatus))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;

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
                if (this.PackageStatus != null) hashCode = hashCode * 59 + this.PackageStatus.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                return hashCode;
            }
        }
    }
}
