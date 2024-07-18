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
    public class UpdateAutopilotChartRequestBody : IFormDataBody
    {

        /// <summary>
        /// 上传模板的配置参数，示例如下：\&quot;{\\\&quot;override\\\&quot;:true,\\\&quot;skip_lint\\\&quot;:true,\\\&quot;source\\\&quot;:\\\&quot;package\\\&quot;}\&quot; - skip_lint: whether lint uploaded chart - override: whether override existed chart - visible: update chart visible
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public string Parameters { get; set; }

        /// <summary>
        /// 模板包文件
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart Content { get; set; }


        
        public UpdateAutopilotChartRequestBody WithContent(Stream stream, string filename)
        {
            this.Content = new FormDataFilePart(stream, filename);
            return this;
        }

        public UpdateAutopilotChartRequestBody WithContent(Stream stream, string filename, string contentType)
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
            sb.Append("class UpdateAutopilotChartRequestBody {\n");
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
            return this.Equals(input as UpdateAutopilotChartRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAutopilotChartRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
