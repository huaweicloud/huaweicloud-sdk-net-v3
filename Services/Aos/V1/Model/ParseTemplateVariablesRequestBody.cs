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
    public class ParseTemplateVariablesRequestBody 
    {

        /// <summary>
        /// HCL模板，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的template_body
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板的OBS地址，该模板描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别  请确保OBS地址所在局点与使用RFS服务局点一致。  对应的文件应该是纯tf文件或zip压缩包  纯tf文件需要以“.tf”或者“.tf.json”结尾，并遵守HCL语法，且文件的编码格式须为UTF-8  压缩包目前只支持zip格式，文件需要以\&quot;.zip\&quot;结尾。解压后的文件不得包含\&quot;.tfvars\&quot;文件。解压前最大支持1MB，解压后最大支持1MB。zip压缩包文件数量不能超过100个  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储template_uri对应的模板文件内容。   * template_uri对应的模板文件如果为zip类型，则内部的文件或文件夹名称长度不得超过255个字节，最深路径长度不得超过2048字节，zip包大小不得超过1MB
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseTemplateVariablesRequestBody {\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParseTemplateVariablesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParseTemplateVariablesRequestBody input)
        {
            if (input == null) return false;
            if (this.TemplateBody != input.TemplateBody || (this.TemplateBody != null && !this.TemplateBody.Equals(input.TemplateBody))) return false;
            if (this.TemplateUri != input.TemplateUri || (this.TemplateUri != null && !this.TemplateUri.Equals(input.TemplateUri))) return false;

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
                if (this.TemplateBody != null) hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null) hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
