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
    /// 截图信息。  &gt; 仅当截图成功后才能查询到此信息，未截图、正在截图以及截图失败时，无此字段信息。
    /// </summary>
    public class ThumbnailInfo 
    {

        /// <summary>
        /// 视频截图信息。
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThumbnailRsp> Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dots", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThumbnailRsp> Dots { get; set; }

        /// <summary>
        /// 执行情况描述。
        /// </summary>
        [JsonProperty("exec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDesc { get; set; }

        /// <summary>
        /// 截图状态。  取值如下： - UN_THUMBNAIL：未截图 - THUMBNAILING：截图中 - THUMBNAIL_SUCCEED：截图成功 - THUMBNAIL_FAILED：截图失败
        /// </summary>
        [JsonProperty("thumbnail_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailInfo {\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  dots: ").Append(Dots).Append("\n");
            sb.Append("  execDesc: ").Append(ExecDesc).Append("\n");
            sb.Append("  thumbnailStatus: ").Append(ThumbnailStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThumbnailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThumbnailInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sample == input.Sample ||
                    this.Sample != null &&
                    input.Sample != null &&
                    this.Sample.SequenceEqual(input.Sample)
                ) && 
                (
                    this.Dots == input.Dots ||
                    this.Dots != null &&
                    input.Dots != null &&
                    this.Dots.SequenceEqual(input.Dots)
                ) && 
                (
                    this.ExecDesc == input.ExecDesc ||
                    (this.ExecDesc != null &&
                    this.ExecDesc.Equals(input.ExecDesc))
                ) && 
                (
                    this.ThumbnailStatus == input.ThumbnailStatus ||
                    (this.ThumbnailStatus != null &&
                    this.ThumbnailStatus.Equals(input.ThumbnailStatus))
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
                if (this.Sample != null)
                    hashCode = hashCode * 59 + this.Sample.GetHashCode();
                if (this.Dots != null)
                    hashCode = hashCode * 59 + this.Dots.GetHashCode();
                if (this.ExecDesc != null)
                    hashCode = hashCode * 59 + this.ExecDesc.GetHashCode();
                if (this.ThumbnailStatus != null)
                    hashCode = hashCode * 59 + this.ThumbnailStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
