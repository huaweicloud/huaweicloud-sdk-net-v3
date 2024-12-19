using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBuiltInConformancePackTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 预定义合规包模板ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 预定义合规包模板名称。
        /// </summary>
        [JsonProperty("template_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateKey { get; set; }

        /// <summary>
        /// 预定义合规包模板描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 预定义合规包模板内容。
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// 预定义合规包模板参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TemplateParameterDefinition> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBuiltInConformancePackTemplateResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  templateKey: ").Append(TemplateKey).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBuiltInConformancePackTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBuiltInConformancePackTemplateResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TemplateKey != input.TemplateKey || (this.TemplateKey != null && !this.TemplateKey.Equals(input.TemplateKey))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.TemplateBody != input.TemplateBody || (this.TemplateBody != null && !this.TemplateBody.Equals(input.TemplateBody))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TemplateKey != null) hashCode = hashCode * 59 + this.TemplateKey.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TemplateBody != null) hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
