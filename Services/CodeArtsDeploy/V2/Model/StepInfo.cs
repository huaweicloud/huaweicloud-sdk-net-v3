using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 子步骤信息
    /// </summary>
    public class StepInfo 
    {

        /// <summary>
        /// 请求的region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 步骤名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 当前偏移量
        /// </summary>
        [JsonProperty("current_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentOffset { get; set; }

        /// <summary>
        /// 任务执行时长
        /// </summary>
        [JsonProperty("elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ElapsedTime { get; set; }

        /// <summary>
        /// 常见问题
        /// </summary>
        [JsonProperty("faq_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FaqUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepInfo {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  currentOffset: ").Append(CurrentOffset).Append("\n");
            sb.Append("  elapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  faqUrl: ").Append(FaqUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepInfo input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CurrentOffset != input.CurrentOffset || (this.CurrentOffset != null && !this.CurrentOffset.Equals(input.CurrentOffset))) return false;
            if (this.ElapsedTime != input.ElapsedTime || (this.ElapsedTime != null && !this.ElapsedTime.Equals(input.ElapsedTime))) return false;
            if (this.FaqUrl != input.FaqUrl || (this.FaqUrl != null && !this.FaqUrl.Equals(input.FaqUrl))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CurrentOffset != null) hashCode = hashCode * 59 + this.CurrentOffset.GetHashCode();
                if (this.ElapsedTime != null) hashCode = hashCode * 59 + this.ElapsedTime.GetHashCode();
                if (this.FaqUrl != null) hashCode = hashCode * 59 + this.FaqUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
