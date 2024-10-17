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
    public class AssetInfo 
    {

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 媒资状态。  取值如下： - UNCREATED：未创建（媒资ID不存在 ） - DELETED：已删除 - CANCELLED：上传取消 - SERVER_ERROR：上传失败（点播服务端故障） - UPLOAD_FAILED：上传失败（向OBS上传失败） - CREATING：创建中 - PUBLISHED：已发布 - WAITING_TRANSCODE：待发布（转码排队中） - TRANSCODING：待发布（转码中） - TRANSCODE_FAILED：待发布（转码失败） - TRANSCODE_SUCCEED：待发布（转码成功） - CREATED：待发布（未转码） - NO_ASSET：该媒资不存在 - DELETING：正在删除 - DELETE_FAILED：删除失败 - OBS_CREATING：OBS转存方式创建中 - OBS_CREATE_FAILED： OBS转存失败 - OBS_CREATE_SUCCESS： OBS转存成功
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 媒资子状态或描述信息。 - 对于媒资异常场景，描述具体的异常原因。 - 对于正常场景，描述媒资的处理信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否是多转码模式 
        /// </summary>
        [JsonProperty("is_multi_transcode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiTranscode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public BaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 转码文件的播放信息。 - HLS或DASH：此数组的成员个数为n+1，n为转码输出路数。 - MP4：此数组的成员个数为n，n为转码输出路数。
        /// </summary>
        [JsonProperty("play_info_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlayInfo> PlayInfoArray { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetInfo {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isMultiTranscode: ").Append(IsMultiTranscode).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  playInfoArray: ").Append(PlayInfoArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetInfo input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsMultiTranscode != input.IsMultiTranscode || (this.IsMultiTranscode != null && !this.IsMultiTranscode.Equals(input.IsMultiTranscode))) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.PlayInfoArray != input.PlayInfoArray || (this.PlayInfoArray != null && input.PlayInfoArray != null && !this.PlayInfoArray.SequenceEqual(input.PlayInfoArray))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsMultiTranscode != null) hashCode = hashCode * 59 + this.IsMultiTranscode.GetHashCode();
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.PlayInfoArray != null) hashCode = hashCode * 59 + this.PlayInfoArray.GetHashCode();
                return hashCode;
            }
        }
    }
}
