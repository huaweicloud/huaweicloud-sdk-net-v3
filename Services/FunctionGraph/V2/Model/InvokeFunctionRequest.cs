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
        /// 
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Cff-Log-Type", IsHeader = true)]
        [JsonProperty("X-Cff-Log-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XCffLogType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-CFF-Request-Version", IsHeader = true)]
        [JsonProperty("X-CFF-Request-Version", NullValueHandling = NullValueHandling.Ignore)]
        public string XCFFRequestVersion { get; set; }

        /// <summary>
        /// 执行函数请求体，为json格式。
        /// </summary>
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
            if (input == null)
                return false;

            return 
                (
                    this.FunctionUrn == input.FunctionUrn ||
                    (this.FunctionUrn != null &&
                    this.FunctionUrn.Equals(input.FunctionUrn))
                ) && 
                (
                    this.XCffLogType == input.XCffLogType ||
                    (this.XCffLogType != null &&
                    this.XCffLogType.Equals(input.XCffLogType))
                ) && 
                (
                    this.XCFFRequestVersion == input.XCFFRequestVersion ||
                    (this.XCFFRequestVersion != null &&
                    this.XCFFRequestVersion.Equals(input.XCFFRequestVersion))
                ) && 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
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
                if (this.FunctionUrn != null)
                    hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                if (this.XCffLogType != null)
                    hashCode = hashCode * 59 + this.XCffLogType.GetHashCode();
                if (this.XCFFRequestVersion != null)
                    hashCode = hashCode * 59 + this.XCFFRequestVersion.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
