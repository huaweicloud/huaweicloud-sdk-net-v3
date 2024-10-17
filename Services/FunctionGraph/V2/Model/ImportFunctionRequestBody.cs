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
    /// 导入函数请求结构体
    /// </summary>
    public class ImportFunctionRequestBody 
    {

        /// <summary>
        /// 函数名
        /// </summary>
        [JsonProperty("func_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncName { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 函数代码。代码必须要进行base64编码
        /// </summary>
        [JsonProperty("file_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCode { get; set; }

        /// <summary>
        /// 应用名称，默认为default
        /// </summary>
        [JsonProperty("package", NullValueHandling = NullValueHandling.Ignore)]
        public string Package { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportFunctionRequestBody {\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  fileCode: ").Append(FileCode).Append("\n");
            sb.Append("  package: ").Append(Package).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportFunctionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportFunctionRequestBody input)
        {
            if (input == null) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.FileCode != input.FileCode || (this.FileCode != null && !this.FileCode.Equals(input.FileCode))) return false;
            if (this.Package != input.Package || (this.Package != null && !this.Package.Equals(input.Package))) return false;

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
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FileCode != null) hashCode = hashCode * 59 + this.FileCode.GetHashCode();
                if (this.Package != null) hashCode = hashCode * 59 + this.Package.GetHashCode();
                return hashCode;
            }
        }
    }
}
