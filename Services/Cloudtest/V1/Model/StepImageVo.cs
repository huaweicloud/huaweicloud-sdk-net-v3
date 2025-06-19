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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class StepImageVo 
    {

        /// <summary>
        /// 测试步骤图片id
        /// </summary>
        [JsonProperty("img_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgId { get; set; }

        /// <summary>
        /// 测试步骤图片路径
        /// </summary>
        [JsonProperty("img_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepImageVo {\n");
            sb.Append("  imgId: ").Append(ImgId).Append("\n");
            sb.Append("  imgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepImageVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepImageVo input)
        {
            if (input == null) return false;
            if (this.ImgId != input.ImgId || (this.ImgId != null && !this.ImgId.Equals(input.ImgId))) return false;
            if (this.ImgUrl != input.ImgUrl || (this.ImgUrl != null && !this.ImgUrl.Equals(input.ImgUrl))) return false;

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
                if (this.ImgId != null) hashCode = hashCode * 59 + this.ImgId.GetHashCode();
                if (this.ImgUrl != null) hashCode = hashCode * 59 + this.ImgUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
