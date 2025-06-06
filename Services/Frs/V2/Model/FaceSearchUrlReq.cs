using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FaceSearchUrlReq 
    {

        /// <summary>
        /// [过滤条件，参考[filter语法](https://support.huaweicloud.com/api-face/face_02_0014.html)。](tag:hc) [过滤条件，参考[filter语法](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0014.html)。](tag:hk)
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 返回查询到的最相似的N张人脸，N默认为10。
        /// </summary>
        [JsonProperty("top_n", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopN { get; set; }

        /// <summary>
        /// [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/api-face/face_02_0006.html)。](tag:hc) [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0006.html)。](tag:hk)
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 指定返回的自定义字段。
        /// </summary>
        [JsonProperty("return_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReturnFields { get; set; }

        /// <summary>
        /// 人脸相似度阈值，低于这个阈值则不返回，取值范围0~1，一般情况下建议取值0.93，默认为0。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }

        /// <summary>
        /// [支持字段排序，参考[sort语法](https://support.huaweicloud.com/api-face/face_02_0013.html)。](tag:hc) [支持字段排序，参考[sort语法](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0013.html)。](tag:hk)
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> Sort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceSearchUrlReq {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  topN: ").Append(TopN).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  returnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceSearchUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceSearchUrlReq input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.TopN != input.TopN || (this.TopN != null && !this.TopN.Equals(input.TopN))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.ReturnFields != input.ReturnFields || (this.ReturnFields != null && input.ReturnFields != null && !this.ReturnFields.SequenceEqual(input.ReturnFields))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && input.Sort != null && !this.Sort.SequenceEqual(input.Sort))) return false;

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
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.TopN != null) hashCode = hashCode * 59 + this.TopN.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ReturnFields != null) hashCode = hashCode * 59 + this.ReturnFields.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
