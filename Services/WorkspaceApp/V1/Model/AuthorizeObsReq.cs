using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 获取ak/sk时候传入的文件名称（带后缀）。
    /// </summary>
    public class AuthorizeObsReq 
    {

        /// <summary>
        /// 应用名称,名称需满足如下规则: 1. 文件名前缀由可见字符和空格组成，且不能为全空格。 2. 长度范围1~255个字符。 3. 结尾必须是&#x60;.msi&#x60;或者&#x60;.exe&#x60;或者&#x60;.zip&#x60;或者&#x60;.rar&#x60;。
        /// </summary>
        [JsonProperty("app_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppFileName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeObsReq {\n");
            sb.Append("  appFileName: ").Append(AppFileName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeObsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeObsReq input)
        {
            if (input == null) return false;
            if (this.AppFileName != input.AppFileName || (this.AppFileName != null && !this.AppFileName.Equals(input.AppFileName))) return false;

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
                if (this.AppFileName != null) hashCode = hashCode * 59 + this.AppFileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
