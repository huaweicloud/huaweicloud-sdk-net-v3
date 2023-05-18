using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CacheRules 
    {

        /// <summary>
        /// 匹配所有文件 all， 按文件后缀匹配 file_extension， 按目录匹配 catalog， 全路径匹配 full_path， 按首页匹配 home_page。
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// 缓存匹配设置。 当match_type为all时，为空。当match_type为file_extension时，为文件后缀，输入首字符为“.”，以“,”进行分隔， 如.jpg,.zip,.exe，并且输入的文 件名后缀总数不超过20个。 当match_type为catalog时，为目录，输入要求以“/”作为首字符， 以“,”进行分隔，如/test/folder01,/test/folder02，并且输入的目录路径总数不超过20个。  当match_type为full_path时，为全路径，输入要求以“/”作为首字符，支持匹配指定目录下的具体文件，或者带通配符“*”的文件， 如/test/index.html或/test/_*.jpg。 当match_type为home_page时，为空。
        /// </summary>
        [JsonProperty("match_value", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchValue { get; set; }

        /// <summary>
        /// 缓存时间。最大支持365天。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 缓存过期时间单位。s：秒；m：分；h：小时；d：天
        /// </summary>
        [JsonProperty("ttl_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TtlUnit { get; set; }

        /// <summary>
        /// 此条配置的优先级, 默认值1，数值越大，优先级越高。取值范围为1-100，优先级不能相同
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 缓存遵循源站开关（on：打开，off：关闭）
        /// </summary>
        [JsonProperty("follow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowOrigin { get; set; }

        /// <summary>
        /// 忽略指定URL参数： del_params， 保留指定URL参数： reserve_params， 忽略全部URL参数： ignore_url_params， 使用完整URL参数： full_url。
        /// </summary>
        [JsonProperty("url_parameter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlParameterType { get; set; }

        /// <summary>
        /// 最多设置10条，以\&quot;,\&quot;分隔
        /// </summary>
        [JsonProperty("url_parameter_value", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlParameterValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheRules {\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  matchValue: ").Append(MatchValue).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  ttlUnit: ").Append(TtlUnit).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  followOrigin: ").Append(FollowOrigin).Append("\n");
            sb.Append("  urlParameterType: ").Append(UrlParameterType).Append("\n");
            sb.Append("  urlParameterValue: ").Append(UrlParameterValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CacheRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CacheRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatchType == input.MatchType ||
                    (this.MatchType != null &&
                    this.MatchType.Equals(input.MatchType))
                ) && 
                (
                    this.MatchValue == input.MatchValue ||
                    (this.MatchValue != null &&
                    this.MatchValue.Equals(input.MatchValue))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
                ) && 
                (
                    this.TtlUnit == input.TtlUnit ||
                    (this.TtlUnit != null &&
                    this.TtlUnit.Equals(input.TtlUnit))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.FollowOrigin == input.FollowOrigin ||
                    (this.FollowOrigin != null &&
                    this.FollowOrigin.Equals(input.FollowOrigin))
                ) && 
                (
                    this.UrlParameterType == input.UrlParameterType ||
                    (this.UrlParameterType != null &&
                    this.UrlParameterType.Equals(input.UrlParameterType))
                ) && 
                (
                    this.UrlParameterValue == input.UrlParameterValue ||
                    (this.UrlParameterValue != null &&
                    this.UrlParameterValue.Equals(input.UrlParameterValue))
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
                if (this.MatchType != null)
                    hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.MatchValue != null)
                    hashCode = hashCode * 59 + this.MatchValue.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.TtlUnit != null)
                    hashCode = hashCode * 59 + this.TtlUnit.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.FollowOrigin != null)
                    hashCode = hashCode * 59 + this.FollowOrigin.GetHashCode();
                if (this.UrlParameterType != null)
                    hashCode = hashCode * 59 + this.UrlParameterType.GetHashCode();
                if (this.UrlParameterValue != null)
                    hashCode = hashCode * 59 + this.UrlParameterValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
