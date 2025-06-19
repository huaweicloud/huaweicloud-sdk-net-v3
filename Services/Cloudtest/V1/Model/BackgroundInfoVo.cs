using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackgroundInfoVo 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// cover文件名称
        /// </summary>
        [JsonProperty("cover_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverFileName { get; set; }

        /// <summary>
        /// 背景文件名称
        /// </summary>
        [JsonProperty("background_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundFileName { get; set; }

        /// <summary>
        /// logo文件名称
        /// </summary>
        [JsonProperty("logo_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoFileName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundInfoVo {\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  coverFileName: ").Append(CoverFileName).Append("\n");
            sb.Append("  backgroundFileName: ").Append(BackgroundFileName).Append("\n");
            sb.Append("  logoFileName: ").Append(LogoFileName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackgroundInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackgroundInfoVo input)
        {
            if (input == null) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.CoverFileName != input.CoverFileName || (this.CoverFileName != null && !this.CoverFileName.Equals(input.CoverFileName))) return false;
            if (this.BackgroundFileName != input.BackgroundFileName || (this.BackgroundFileName != null && !this.BackgroundFileName.Equals(input.BackgroundFileName))) return false;
            if (this.LogoFileName != input.LogoFileName || (this.LogoFileName != null && !this.LogoFileName.Equals(input.LogoFileName))) return false;

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
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.CoverFileName != null) hashCode = hashCode * 59 + this.CoverFileName.GetHashCode();
                if (this.BackgroundFileName != null) hashCode = hashCode * 59 + this.BackgroundFileName.GetHashCode();
                if (this.LogoFileName != null) hashCode = hashCode * 59 + this.LogoFileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
