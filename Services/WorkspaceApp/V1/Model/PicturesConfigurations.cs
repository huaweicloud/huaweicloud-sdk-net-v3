using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// “图片”文件夹重定向配置
    /// </summary>
    public class PicturesConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("pictures_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicturesStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("pictures_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicturesRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("pictures_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PicturesStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("pictures_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PicturesRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("pictures_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicturesExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("pictures_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicturesMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("pictures_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicturesMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PicturesConfigurations {\n");
            sb.Append("  picturesStatus: ").Append(PicturesStatus).Append("\n");
            sb.Append("  picturesRedirectionType: ").Append(PicturesRedirectionType).Append("\n");
            sb.Append("  picturesStoragePath: ").Append(PicturesStoragePath).Append("\n");
            sb.Append("  picturesRelativePath: ").Append(PicturesRelativePath).Append("\n");
            sb.Append("  picturesExclusiveRights: ").Append(PicturesExclusiveRights).Append("\n");
            sb.Append("  picturesMoveContents: ").Append(PicturesMoveContents).Append("\n");
            sb.Append("  picturesMoveContentOnPolicyRemoval: ").Append(PicturesMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PicturesConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PicturesConfigurations input)
        {
            if (input == null) return false;
            if (this.PicturesStatus != input.PicturesStatus || (this.PicturesStatus != null && !this.PicturesStatus.Equals(input.PicturesStatus))) return false;
            if (this.PicturesRedirectionType != input.PicturesRedirectionType || (this.PicturesRedirectionType != null && !this.PicturesRedirectionType.Equals(input.PicturesRedirectionType))) return false;
            if (this.PicturesStoragePath != input.PicturesStoragePath || (this.PicturesStoragePath != null && !this.PicturesStoragePath.Equals(input.PicturesStoragePath))) return false;
            if (this.PicturesRelativePath != input.PicturesRelativePath || (this.PicturesRelativePath != null && !this.PicturesRelativePath.Equals(input.PicturesRelativePath))) return false;
            if (this.PicturesExclusiveRights != input.PicturesExclusiveRights || (this.PicturesExclusiveRights != null && !this.PicturesExclusiveRights.Equals(input.PicturesExclusiveRights))) return false;
            if (this.PicturesMoveContents != input.PicturesMoveContents || (this.PicturesMoveContents != null && !this.PicturesMoveContents.Equals(input.PicturesMoveContents))) return false;
            if (this.PicturesMoveContentOnPolicyRemoval != input.PicturesMoveContentOnPolicyRemoval || (this.PicturesMoveContentOnPolicyRemoval != null && !this.PicturesMoveContentOnPolicyRemoval.Equals(input.PicturesMoveContentOnPolicyRemoval))) return false;

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
                if (this.PicturesStatus != null) hashCode = hashCode * 59 + this.PicturesStatus.GetHashCode();
                if (this.PicturesRedirectionType != null) hashCode = hashCode * 59 + this.PicturesRedirectionType.GetHashCode();
                if (this.PicturesStoragePath != null) hashCode = hashCode * 59 + this.PicturesStoragePath.GetHashCode();
                if (this.PicturesRelativePath != null) hashCode = hashCode * 59 + this.PicturesRelativePath.GetHashCode();
                if (this.PicturesExclusiveRights != null) hashCode = hashCode * 59 + this.PicturesExclusiveRights.GetHashCode();
                if (this.PicturesMoveContents != null) hashCode = hashCode * 59 + this.PicturesMoveContents.GetHashCode();
                if (this.PicturesMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.PicturesMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
