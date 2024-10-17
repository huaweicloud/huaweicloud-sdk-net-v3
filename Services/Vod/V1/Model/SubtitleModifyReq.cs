using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubtitleModifyReq 
    {

        /// <summary>
        /// 媒资ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 字幕默认语言(字幕必须存在)
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// 需新增或修改的字幕
        /// </summary>
        [JsonProperty("add_subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddSubtitle> AddSubtitles { get; set; }

        /// <summary>
        /// 需删除的字幕，language不能与add_subtitles重复
        /// </summary>
        [JsonProperty("delete_subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteSubtitle> DeleteSubtitles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtitleModifyReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  addSubtitles: ").Append(AddSubtitles).Append("\n");
            sb.Append("  deleteSubtitles: ").Append(DeleteSubtitles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtitleModifyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtitleModifyReq input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage || (this.DefaultLanguage != null && !this.DefaultLanguage.Equals(input.DefaultLanguage))) return false;
            if (this.AddSubtitles != input.AddSubtitles || (this.AddSubtitles != null && input.AddSubtitles != null && !this.AddSubtitles.SequenceEqual(input.AddSubtitles))) return false;
            if (this.DeleteSubtitles != input.DeleteSubtitles || (this.DeleteSubtitles != null && input.DeleteSubtitles != null && !this.DeleteSubtitles.SequenceEqual(input.DeleteSubtitles))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.DefaultLanguage != null) hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.AddSubtitles != null) hashCode = hashCode * 59 + this.AddSubtitles.GetHashCode();
                if (this.DeleteSubtitles != null) hashCode = hashCode * 59 + this.DeleteSubtitles.GetHashCode();
                return hashCode;
            }
        }
    }
}
