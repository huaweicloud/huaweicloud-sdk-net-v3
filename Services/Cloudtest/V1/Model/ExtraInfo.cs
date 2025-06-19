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
    /// 
    /// </summary>
    public class ExtraInfo 
    {

        /// <summary>
        /// 子级导入的包
        /// </summary>
        [JsonProperty("childImportPackage", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChildImportPackage { get; set; }

        /// <summary>
        /// 文档链接
        /// </summary>
        [JsonProperty("document_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentLink { get; set; }

        /// <summary>
        /// http请求方法
        /// </summary>
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// HTTP请求的URL
        /// </summary>
        [JsonProperty("http_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// 导入的包
        /// </summary>
        [JsonProperty("importPackage", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImportPackage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mock", NullValueHandling = NullValueHandling.Ignore)]
        public MockInfo Mock { get; set; }

        /// <summary>
        /// 输出参数
        /// </summary>
        [JsonProperty("outputParam", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> OutputParam { get; set; }

        /// <summary>
        /// 参数依赖
        /// </summary>
        [JsonProperty("param_dependent", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamDependent { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraInfo {\n");
            sb.Append("  childImportPackage: ").Append(ChildImportPackage).Append("\n");
            sb.Append("  documentLink: ").Append(DocumentLink).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  httpUrl: ").Append(HttpUrl).Append("\n");
            sb.Append("  importPackage: ").Append(ImportPackage).Append("\n");
            sb.Append("  mock: ").Append(Mock).Append("\n");
            sb.Append("  outputParam: ").Append(OutputParam).Append("\n");
            sb.Append("  paramDependent: ").Append(ParamDependent).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtraInfo input)
        {
            if (input == null) return false;
            if (this.ChildImportPackage != input.ChildImportPackage || (this.ChildImportPackage != null && input.ChildImportPackage != null && !this.ChildImportPackage.SequenceEqual(input.ChildImportPackage))) return false;
            if (this.DocumentLink != input.DocumentLink || (this.DocumentLink != null && !this.DocumentLink.Equals(input.DocumentLink))) return false;
            if (this.HttpMethod != input.HttpMethod || (this.HttpMethod != null && !this.HttpMethod.Equals(input.HttpMethod))) return false;
            if (this.HttpUrl != input.HttpUrl || (this.HttpUrl != null && !this.HttpUrl.Equals(input.HttpUrl))) return false;
            if (this.ImportPackage != input.ImportPackage || (this.ImportPackage != null && input.ImportPackage != null && !this.ImportPackage.SequenceEqual(input.ImportPackage))) return false;
            if (this.Mock != input.Mock || (this.Mock != null && !this.Mock.Equals(input.Mock))) return false;
            if (this.OutputParam != input.OutputParam || (this.OutputParam != null && input.OutputParam != null && !this.OutputParam.SequenceEqual(input.OutputParam))) return false;
            if (this.ParamDependent != input.ParamDependent || (this.ParamDependent != null && !this.ParamDependent.Equals(input.ParamDependent))) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;

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
                if (this.ChildImportPackage != null) hashCode = hashCode * 59 + this.ChildImportPackage.GetHashCode();
                if (this.DocumentLink != null) hashCode = hashCode * 59 + this.DocumentLink.GetHashCode();
                if (this.HttpMethod != null) hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.HttpUrl != null) hashCode = hashCode * 59 + this.HttpUrl.GetHashCode();
                if (this.ImportPackage != null) hashCode = hashCode * 59 + this.ImportPackage.GetHashCode();
                if (this.Mock != null) hashCode = hashCode * 59 + this.Mock.GetHashCode();
                if (this.OutputParam != null) hashCode = hashCode * 59 + this.OutputParam.GetHashCode();
                if (this.ParamDependent != null) hashCode = hashCode * 59 + this.ParamDependent.GetHashCode();
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
