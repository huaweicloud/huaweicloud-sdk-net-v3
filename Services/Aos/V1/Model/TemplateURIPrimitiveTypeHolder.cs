using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TemplateURIPrimitiveTypeHolder 
    {

        /// <summary>
        /// HCL模板的OBS地址，该模板描述了资源的目标状态  OBS地址必须为同region的OBS地址，暂不支持跨region访问  对应的文件应该是纯tf文件或zip压缩包  纯tf文件需要以&#x60;.tf&#x60;或者&#x60;.tfjson&#x60;结尾，并遵守hcl语法  压缩包目前只支持zip格式，文件需要以\&quot;.zip\&quot;结尾。解压后的文件不得包含\&quot;.tfvars\&quot;文件  template_body和template_uri 必须有且只有一个存在 
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateURIPrimitiveTypeHolder {\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateURIPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateURIPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateUri == input.TemplateUri ||
                    (this.TemplateUri != null &&
                    this.TemplateUri.Equals(input.TemplateUri))
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
                if (this.TemplateUri != null)
                    hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
