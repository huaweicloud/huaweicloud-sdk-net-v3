using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportRuleAclRequestBody : IFormDataBody
    {

        /// <summary>
        /// **参数解释**： 规则文件 **约束限制**： 请按模板要求的文件类型和内容导入规则，否则无法成功导入 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart File { get; set; }


        
        public ImportRuleAclRequestBody WithFile(Stream stream, string filename)
        {
            this.File = new FormDataFilePart(stream, filename);
            return this;
        }

        public ImportRuleAclRequestBody WithFile(Stream stream, string filename, string contentType)
        {
            this.File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("file", File);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportRuleAclRequestBody {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportRuleAclRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportRuleAclRequestBody input)
        {
            if (input == null) return false;
            if (this.File != input.File || (this.File != null && !this.File.Equals(input.File))) return false;

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
                if (this.File != null) hashCode = hashCode * 59 + this.File.GetHashCode();
                return hashCode;
            }
        }
    }
}
