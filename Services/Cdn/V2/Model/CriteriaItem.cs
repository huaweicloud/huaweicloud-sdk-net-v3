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
    /// **参数解释：** 匹配条件列表 **约束限制：** 不涉及
    /// </summary>
    public class CriteriaItem 
    {

        /// <summary>
        /// **参数解释：** 匹配目标类型 **约束限制：** 不涉及 **取值范围：** - schema: 客户端请求使用的协议类型 - method: 客户端请求IP使用的请求方法 - path: 客户端请求URL路径 - arg: 客户端请求URL中的查询参数 - extension: 客户端请求IP内容的文件后缀 - filename: 客户端请求IP内容的文件名称 - header: HTTP请求头部 - clientip: 客户端请求IP的客户端IP - clientip_version: 客户端请求IP的客户端IP版本 - ua: 客户端请求IP头中的User-Agent - ngx_variable: Nginx变量 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchTargetType { get; set; }

        /// <summary>
        /// **参数解释：** 匹配目标名称 **约束限制：** 不涉及 **取值范围：** - 当匹配目标类型为schema、method、path、extension、filename、ua时，该值为空 - 当匹配目标类型为arg时表示查询参数名，长度1-100，由数字，大小写字母，中划线和下划线组成，只能以字母开头 - 当匹配目标类型为header时表示请求头的名称，长度1-100，由数字，大小写字母，中划线和下划线组成，只能以字母开头 - 当匹配目标类型为clientip时表示ip来源，取值：connect：建联IP；xff：x-forwarded-for头 - 当匹配目标类型为clientip_version时表示ip版本来源，取值：connect：建联IP；xff：x-forwarded-for头 - 当匹配目标类型为ngx_variable时表示Nginx变量名，仅支持$protocol、$arg_、$http_、$scheme、$uri、$ssl_protocol、$ssl_server_name、$remote_addr、$http2、$request_method、$sent_http_ **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchTargetName { get; set; }

        /// <summary>
        /// **参数解释：** 匹配算法 **约束限制：** 不涉及 **取值范围：** contains：包含匹配，匹配到match_pattern任意一个条件即匹配成功 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// **参数解释：** 匹配内容 **约束限制：** 不涉及 **取值范围：** - 当匹配目标类型为schema时，取值：HTTP，HTTPS - 当匹配目标类型为method时，取值：GET，PUT，POST，DELETE，HEAD，OPTIONS，PATCH，TRACE，CONNECT - 当匹配目标类型为clientip_version时，取值：IPv4，IPv6 - 当匹配目标类型为path和ua时，支持配置通配符“*” **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("match_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MatchPattern { get; set; }

        /// <summary>
        /// **参数解释：** 是否取反，与match_type配合使用。例：negate配置为true，match_type配置为contains，则实际业务逻辑将转换为not_contains **约束限制：** 不涉及 **取值范围：** - true: 取反 - false: 不取反 **默认取值：** false: 不取反
        /// </summary>
        [JsonProperty("negate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Negate { get; set; }

        /// <summary>
        /// **参数解释：** 是否区分大小写 **约束限制：** 不涉及 **取值范围：** - true: 区分大小写 - false: 不区分大小写 **默认取值：** false: 不区分大小写
        /// </summary>
        [JsonProperty("case_sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// **参数解释：** 嵌套条件逻辑运算符 **约束限制：** 不涉及 **取值范围：** - and: 与关系 - or: 或关系 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("logic", NullValueHandling = NullValueHandling.Ignore)]
        public string Logic { get; set; }

        /// <summary>
        /// **参数解释：** 嵌套条件列表 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)]
        public List<CriteriaItem> Criteria { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriteriaItem {\n");
            sb.Append("  matchTargetType: ").Append(MatchTargetType).Append("\n");
            sb.Append("  matchTargetName: ").Append(MatchTargetName).Append("\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  matchPattern: ").Append(MatchPattern).Append("\n");
            sb.Append("  negate: ").Append(Negate).Append("\n");
            sb.Append("  caseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  logic: ").Append(Logic).Append("\n");
            sb.Append("  criteria: ").Append(Criteria).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CriteriaItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CriteriaItem input)
        {
            if (input == null) return false;
            if (this.MatchTargetType != input.MatchTargetType || (this.MatchTargetType != null && !this.MatchTargetType.Equals(input.MatchTargetType))) return false;
            if (this.MatchTargetName != input.MatchTargetName || (this.MatchTargetName != null && !this.MatchTargetName.Equals(input.MatchTargetName))) return false;
            if (this.MatchType != input.MatchType || (this.MatchType != null && !this.MatchType.Equals(input.MatchType))) return false;
            if (this.MatchPattern != input.MatchPattern || (this.MatchPattern != null && input.MatchPattern != null && !this.MatchPattern.SequenceEqual(input.MatchPattern))) return false;
            if (this.Negate != input.Negate || (this.Negate != null && !this.Negate.Equals(input.Negate))) return false;
            if (this.CaseSensitive != input.CaseSensitive || (this.CaseSensitive != null && !this.CaseSensitive.Equals(input.CaseSensitive))) return false;
            if (this.Logic != input.Logic || (this.Logic != null && !this.Logic.Equals(input.Logic))) return false;
            if (this.Criteria != input.Criteria || (this.Criteria != null && input.Criteria != null && !this.Criteria.SequenceEqual(input.Criteria))) return false;

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
                if (this.MatchTargetType != null) hashCode = hashCode * 59 + this.MatchTargetType.GetHashCode();
                if (this.MatchTargetName != null) hashCode = hashCode * 59 + this.MatchTargetName.GetHashCode();
                if (this.MatchType != null) hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.MatchPattern != null) hashCode = hashCode * 59 + this.MatchPattern.GetHashCode();
                if (this.Negate != null) hashCode = hashCode * 59 + this.Negate.GetHashCode();
                if (this.CaseSensitive != null) hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.Logic != null) hashCode = hashCode * 59 + this.Logic.GetHashCode();
                if (this.Criteria != null) hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                return hashCode;
            }
        }
    }
}
