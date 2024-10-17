using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadAutopilotChartRequestBody : IFormDataBody
    {

        /// <summary>
        /// 上传模板的配置参数，示例如下：\&quot;{\\\&quot;override\\\&quot;:true,\\\&quot;skip_lint\\\&quot;:true,\\\&quot;source\\\&quot;:\\\&quot;package\\\&quot;}\&quot;  - skip_lint: 是否验证上传的模板 - override: 是否覆盖已存在的模板 - visible: 模板是否可见 
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public string Parameters { get; set; }

        /// <summary>
        /// 模板包文件
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart Content { get; set; }


        
        public UploadAutopilotChartRequestBody WithContent(Stream stream, string filename)
        {
            this.Content = new FormDataFilePart(stream, filename);
            return this;
        }

        public UploadAutopilotChartRequestBody WithContent(Stream stream, string filename, string contentType)
        {
            this.Content = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            if (Parameters != null) {
                formData.Add("parameters", new FormDataPart<string>(Parameters));
            }
            formData.Add("content", Content);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAutopilotChartRequestBody {\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAutopilotChartRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAutopilotChartRequestBody input)
        {
            if (input == null) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
