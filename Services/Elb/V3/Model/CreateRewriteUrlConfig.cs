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
    /// 转发到的后端主机组的URL配置。rewrite_url_enable为true时，该字段必须传入。
    /// </summary>
    public class CreateRewriteUrlConfig 
    {

        /// <summary>
        /// url重写的主机名。字符串只能包含英文字母、数字、“-”、“.”，必须以字母、数字开头。默认值${host}表示继承原值（即与被重写请求保持一致）。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// url重定向的路径。默认值${path}表示继承原值（即与被重写请求保持一致）。 只能包含英文字母、数字、_~&#39;;@^-%#&amp;$.*+?,&#x3D;!:|\\/()，且必须以\&quot;/\&quot;开头。其中$1-$9会匹配请求url通配符星号(*)，当正则匹配分组小于指定数字，则$指定数字结果为空。$后面跟字母，匹配结果均为空，直到下一个特殊字符出现，例如$abc#123，则匹配结果为#123；$后面跟特殊字符则直接输出特殊字符，例如$#匹配结果为$#.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// url重定向的查询字符串。默认${query}表示继承原值（即与被重写请求保持一致）。 只能包含英文字母、数字和特殊字符：!$&amp;&#39;()*+,-./:;&#x3D;?@^_&#x60;。字母区分大小写。其中$1-$9会匹配请求url通配符星号（*），当正则匹配分组小于指定数字，则$指定数字结果为空。$后面跟字母，匹配结果均为空，直到下一个特殊字符出现，例如$abc#123，则匹配结果为#123；$后面跟特殊字符则直接输出特殊字符，例如$#匹配结果为$#
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRewriteUrlConfig {\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRewriteUrlConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRewriteUrlConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
        }
    }
}
