using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryJobNoticeItems 
    {

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonProperty("notice_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeType { get; set; }

        /// <summary>
        /// 通知品种开启详情的表
        /// </summary>
        [JsonProperty("enable_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> EnableMap { get; set; }

        /// <summary>
        /// 参数配置
        /// </summary>
        [JsonProperty("param_config", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryJobNoticeItems {\n");
            sb.Append("  noticeType: ").Append(NoticeType).Append("\n");
            sb.Append("  enableMap: ").Append(EnableMap).Append("\n");
            sb.Append("  paramConfig: ").Append(ParamConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryJobNoticeItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryJobNoticeItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NoticeType == input.NoticeType ||
                    (this.NoticeType != null &&
                    this.NoticeType.Equals(input.NoticeType))
                ) && 
                (
                    this.EnableMap == input.EnableMap ||
                    this.EnableMap != null &&
                    input.EnableMap != null &&
                    this.EnableMap.SequenceEqual(input.EnableMap)
                ) && 
                (
                    this.ParamConfig == input.ParamConfig ||
                    (this.ParamConfig != null &&
                    this.ParamConfig.Equals(input.ParamConfig))
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
                if (this.NoticeType != null)
                    hashCode = hashCode * 59 + this.NoticeType.GetHashCode();
                if (this.EnableMap != null)
                    hashCode = hashCode * 59 + this.EnableMap.GetHashCode();
                if (this.ParamConfig != null)
                    hashCode = hashCode * 59 + this.ParamConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
