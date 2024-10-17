using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class InvokeFunctionRequest 
    {

        /// <summary>
        /// 函数的URN，详细解释见FunctionGraph函数模型的描述。
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 取值为：tail（返回函数执行后的4K日志），或者为空（不返回日志）。
        /// </summary>
        [SDKProperty("X-Cff-Log-Type", IsHeader = true)]
        [JsonProperty("X-Cff-Log-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XCffLogType { get; set; }

        /// <summary>
        /// 返回体格式，取值v0,v1。 v0:默认返回文本格式 v1:默认返回json格式，sdk需要使用此值。
        /// </summary>
        [SDKProperty("X-CFF-Request-Version", IsHeader = true)]
        [JsonProperty("X-CFF-Request-Version", NullValueHandling = NullValueHandling.Ignore)]
        public string XCFFRequestVersion { get; set; }

        /// <summary>
        /// 设置本次执行函数使用的内存规格,取值： 128、256、512、768、1024、1280、1536、1792、2048、2560、3072、3584、4096、8192、10240
        /// </summary>
        [SDKProperty("X-Cff-Instance-Memory", IsHeader = true)]
        [JsonProperty("X-Cff-Instance-Memory", NullValueHandling = NullValueHandling.Ignore)]
        public string XCffInstanceMemory { get; set; }

        /// <summary>
        /// 执行函数请求体，为json格式。
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvokeFunctionRequest {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  xCffLogType: ").Append(XCffLogType).Append("\n");
            sb.Append("  xCFFRequestVersion: ").Append(XCFFRequestVersion).Append("\n");
            sb.Append("  xCffInstanceMemory: ").Append(XCffInstanceMemory).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvokeFunctionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InvokeFunctionRequest input)
        {
            if (input == null) return false;
            if (this.FunctionUrn != input.FunctionUrn || (this.FunctionUrn != null && !this.FunctionUrn.Equals(input.FunctionUrn))) return false;
            if (this.XCffLogType != input.XCffLogType || (this.XCffLogType != null && !this.XCffLogType.Equals(input.XCffLogType))) return false;
            if (this.XCFFRequestVersion != input.XCFFRequestVersion || (this.XCFFRequestVersion != null && !this.XCFFRequestVersion.Equals(input.XCFFRequestVersion))) return false;
            if (this.XCffInstanceMemory != input.XCffInstanceMemory || (this.XCffInstanceMemory != null && !this.XCffInstanceMemory.Equals(input.XCffInstanceMemory))) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;

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
                if (this.FunctionUrn != null) hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                if (this.XCffLogType != null) hashCode = hashCode * 59 + this.XCffLogType.GetHashCode();
                if (this.XCFFRequestVersion != null) hashCode = hashCode * 59 + this.XCFFRequestVersion.GetHashCode();
                if (this.XCffInstanceMemory != null) hashCode = hashCode * 59 + this.XCffInstanceMemory.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
