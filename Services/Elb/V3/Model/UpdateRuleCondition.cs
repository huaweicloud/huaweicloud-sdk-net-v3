using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRuleCondition 
    {

        /// <summary>
        /// 匹配项的名称。[该字段固定为空字符串](tag:hcso_dt)  [当type为HOST_NAME、PATH、METHOD、SOURCE_IP时，该字段固定为空字符串。  当type为HEADER时，key表示请求头参数的名称，value表示请求头参数的值。key的长度限制1-40字符，只允许包含字母、数字和-_。 当type为QUERY_STRING时，key表示查询参数的名称，value表示查询参数的值。key的长度限制为1-128字符，不支持空格，中括号，大括号，尖括号，反斜杠，双引号，&#39;#&#39;，&#39;&amp;&#39;，&#39;|&#39;，‘%’，‘~’，字母区分大小写。](tag:hws,hws_hk,ocb,tlf,ctc,hcs,sbc,g42,tm,cmcc,hk_g42,mix,hk_sbc,hws_ocb,fcs,dt,dt_test)
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 匹配项的值。  当type为HOST_NAME时，key固定为空字符串，value表示域名的值。 value长度1-128字符，字符串只能包含英文字母、数字、“-”、“.”或“*”，必须以字母、数字或“*”开头，“*”只能出现在开头且必须以*.开始。  当type为PATH时，key固定为空字符串，value表示请求路径的值。value长度1-128字符。当转发规则的compare_type为STARTS_WITH、EQUAL_TO时，字符串只能包含英文字母、数字、_~&#39;;@^-%#&amp;$.*+?,&#x3D;!:|\\/()\\[\\]{}，且必须以\&quot;/\&quot;开头。  [当type为HEADER时，key表示请求头参数的名称，value表示请求头参数的值。value长度限制1-128字符，不支持空格，双引号，支持以下通配符：*（匹配0个或更多字符）和？（正好匹配1个字符）。  当type为QUERY_STRING时，key表示查询参数的名称，value表示查询参数的值。value长度限制为1-128字符，不支持空格，中括号，大括号，尖括号，反斜杠，双引号，&#39;#&#39;，&#39;&amp;&#39;，&#39;|&#39;，‘%’，‘~’，字母区分大小写，支持通配符：*（匹配0个或更多字符）和？（正好匹配1个字符）  当type为METHOD时，key固定为空字符串，value表示请求方式。value取值范围为：GET, PUT, POST, DELETE, PATCH, HEAD, OPTIONS。  当type为SOURCE_IP时，key固定为空字符串，value表示请求源地址。value为CIDR格式，支持ipv4，ipv6。 例如192.168.0.2/32，2049::49/64。](tag:hws,hws_hk,ocb,tlf,ctc,hcs,sbc,g42,tm,cmcc,hk_g42,mix,hk_sbc,hws_ocb,fcs,dt,dt_test)
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRuleCondition {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRuleCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRuleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
